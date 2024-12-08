using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generic : MonoBehaviour
{
    public class MyClass
    {
        public int i;
        public int j;
    }
    public struct MyStruct
    {
        public string name;
        public int age;
    }

    public class MyList<Titem>
    {
        private Titem[] array = new Titem[4];

        public int count { get; }
        public void Push (Titem i)
        {

        }

        public void insert(int index, Titem item)
        {

        }
        public void remove(Titem index)
        {

        }

        public void clear()
        {

        }

        public void IndexOf(Titem item)
        {
            return;
        }
        public void RemoveAt(int index)
        {

        }
    }
    public void Test<T>(ref T i)
    {

    }
    void Start()
    {
        var mc = new MyClass();
        var ms = new MyStruct();
        var ms2 = new MyStruct();
        ms = ms2;
        int i = 10;
        List<MyClass> standartlist = new List<MyClass>();
        Test<int>(ref i);

        MyList<MyClass> mylist = new MyList<MyClass>();
        mylist.Push(new MyClass());
    }
}

