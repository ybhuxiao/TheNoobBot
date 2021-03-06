﻿using System.Runtime.InteropServices;
using System.Threading;
using nManager.Wow.Class;
using nManager.Wow.Patchables;

namespace nManager.Wow.Helpers
{
    public class ClickOnTerrain
    {
        #region Struct

        [StructLayout(LayoutKind.Explicit, Size = 0x20)]
        public struct StructClickOnTerrain
        {
            [FieldOffset(0x0)] public UInt128 Guid;
            [FieldOffset(0x10)] public float X;
            [FieldOffset(0x14)] public float Y;
            [FieldOffset(0x18)] public float Z;
        }

        #endregion Strut

        public static void Spell(uint spellId, Point point)
        {
            if (spellId <= 0)
                return;
            if (point == null)
                return;
            if (point.X == 0 && point.Y == 0)
                return;

            Spell s = new Spell(spellId);

            s.Launch();

            Thread.Sleep(Usefuls.Latency*1);

            Pulse(point);
        }

        public static void Item(int Entry, Point point)
        {
            if (Entry <= 0)
                return;
            if (point == null)
                return;
            if (!point.IsValid)
                return;

            ItemsManager.UseItem(ItemsManager.GetItemNameById(Entry));


            Thread.Sleep(Usefuls.Latency*2);

            Pulse(point);
        }

        public static void ClickOnly(Point point)
        {
            if (point == null)
                return;
            if (!point.IsValid)
                return;

            Thread.Sleep(Usefuls.Latency + 50);

            Pulse(point);
        }

        private static void Pulse(Point point)
        {
            try
            {
                if (point == null)
                    return;
                if (!point.IsValid)
                    return;

                uint codeCaveStructClickOnTerrain =
                    Memory.WowMemory.Memory.AllocateMemory(Marshal.SizeOf(typeof (StructClickOnTerrain)));

                //Struct
                StructClickOnTerrain structClickOnTerrain = new StructClickOnTerrain {X = point.X, Y = point.Y, Z = point.Z};

                // WRITE
                Memory.WowMemory.Memory.WriteObject(codeCaveStructClickOnTerrain, structClickOnTerrain,
                    typeof (StructClickOnTerrain));


                string[] asm = new[]
                {
                    /*"call " +
                    (Memory.WowProcess.WowModule + (uint) Addresses.FunctionWow.ClntObjMgrGetActivePlayer)
                    ,
                    "test eax, eax",
                    "je @out",*/
                    /*"call " +
                    (Memory.WowProcess.WowModule +
                     (uint) Addresses.FunctionWow.ClntObjMgrGetActivePlayerObj),
                    "test eax, eax",
                    "je @out",*/
                    "push " + codeCaveStructClickOnTerrain,
                    "mov ebx, " + (Memory.WowProcess.WowModule + (uint) Addresses.FunctionWow.Spell_C_HandleTerrainClick),
                    "call ebx",
                    "add esp, 0x4",
                    "@out:",
                    "retn"
                };

                Memory.WowMemory.InjectAndExecute(asm);

                Memory.WowMemory.Memory.FreeMemory(codeCaveStructClickOnTerrain);
            }
            catch
            {
            }
        }
    }
}