using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKTR.Plugin; 
using EloBuddy.SDK; // Please Format this correctly if you have finished this champion. 
 //TODO

namespace OKTR.AIO.Zed
{
    class Program
    {
        static void Main(string[] args)
        {
            new Zed().RegisterPlugin();
        }
    }

    public class Zed : ChampionPluginBase<Spell.SpellBase, Spell.SpellBase, Spell.SpellBase, Spell.SpellBase>
    {
        public override void InitializeSpells()
        {
        }

        public override void InitializeEvents()
        {

        }

        public override void InitializeMenu()
        {

        }

        public override void Combo()
        {
            
        }

        public override void Harass()
        {
            
        }

        public override void Laneclear()
        {
            
        }

        public override void Lasthit()
        {
            
        }

        public override void Jungleclear()
        {
            
        }

        public override void Flee()
        {
            
        }

        public override void PermaActive()
        {
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}