using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace wServer.realm.worlds
{
    public class WineCellarMap : World
    {
        public WineCellarMap()
        {
            Id = PVP_ID;
            Name = "PVP World";
            Background = 0;
            AllowTeleport = false;
            base.FromWorldMap(typeof(RealmManager).Assembly.GetManifestResourceStream("wServer.realm.worlds.pvp.wmap"));
            PVP = true;
        }

        public override World GetInstance(ClientProcessor psr)
        {
            return RealmManager.AddWorld(new WineCellarMap());
        }
    }
}
