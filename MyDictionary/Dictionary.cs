using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class Dictionary<I,P>
    {
        I[] id;
        I[] tempId;
        P[] name;
        P[] plaka;

        public Dictionary()
        {
            id = new I[0];
            name = new P[0];
        }

        public void Add(I key,P value)
        {
            tempId = id;
            plaka = name;

            id = new I[id.Length + 1];
            name = new P[name.Length + 1];

            for (int i = 0; i < plaka.Length; i++)
            {
                plaka[i] = name[i];
                id[i] = tempId[i];
            }
            name[name.Length - 1] = value;
            id[id.Length - 1] = key;

            Console.WriteLine("Plaka: "+key+" /İl: "+value+" Eklendi.");
        }
        
    }
}
