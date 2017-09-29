using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Pan
    {
        private Potato[] potato;
        private Salt salt;
        private Onion[] onion;
        private Oil oil;

        public bool ReadyToGo { get { return Check(); } }

        public void AddSalt(Salt s) {
            salt = s;
        }

        public void AddPotato(Potato[] p)
        {

            if (potato == null)
            {
                potato = p;
                return;
            }

        }
        public void AddChicken(Oil ol)
        {
            oil = ol;
        }
        public void AddOnion(Onion[] o)
        {
            
                if (onion == null)
                {
                    onion = o;
                    return;
                }
        }
        private bool Check()
        {
            if (potato.Length == 0)
            {
                return false;
            }
            if (oil == null)
            {
                return false;
            }
            if (onion.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < potato.Length; ++i)
            {
                if (potato[i] == null)
                {
                    return false;
                }
            }
            for (int i = 0; i < onion.Length; ++i)
            {
                if (onion[i] == null)
                {
                    return false;
                }
            }
            return true;
        }

        public void Getheat() {
            if (!Check())
            {
                return;
            }

            bool flag = false;
            if (flag)
            {
                        for (int i = 0; i < potato.Length; ++i)
                        {
                            potato[i].GetHeat();
                        }
                        for (int i = 0; i < onion.Length; ++i)
                        {
                            onion[i].GetHeat();
                        }
                      
                        oil.GetHeat();
            }
                
            else
            {
                for (int i = 0; i < potato.Length; ++i)
                {
                    potato[i].GetHeat();
                }
                for (int i = 0; i < onion.Length; ++i)
                {
                    onion[i].GetHeat();
                }
                oil.GetHeat();
            }   
        }
        public bool Isready()
        {
            for (int i = 0; i < potato.Length; ++i)
            {
                if (potato[i].Has_ready < 10)
                {
                    return false;
                }
            }
            for (int i = 0; i < onion.Length; ++i)
            {
                if (onion[i].Has_ready < 10)
                {
                    return false;
                }
            }
            
            if (oil.Has_ready < 10)
            {
                return false;
            }
            return true;
        }
    }
}
