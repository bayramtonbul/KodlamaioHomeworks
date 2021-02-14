using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryWork
{
    class MyDictionary<Tkey, TValue>
    {
        Tkey[] itemKey;
        TValue[] itemValue;

        public MyDictionary()
        {
            itemKey = new Tkey[0];
            itemValue = new TValue[0];
        }


        public void Add(Tkey key, TValue value)
        {
            Tkey[] tempArrayKey = itemKey;
            TValue[] tempArrayValue = itemValue;


            itemKey = new Tkey[itemKey.Length + 1];
            itemValue = new TValue[itemValue.Length + 1];

            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                itemKey[i] = tempArrayKey[i];
                itemValue[i] = tempArrayValue[i];

            }


            itemKey[itemKey.Length - 1] = key;
            itemValue[itemValue.Length - 1] = value;

        }



        public int Count
        {
            get { return itemKey.Length; }
        }

 

        public Tkey[] KeyList
        {
            get { return itemKey; }

        }

        public TValue[] ValueList
        {
            get { return itemValue; }

        }

        


    }
}
