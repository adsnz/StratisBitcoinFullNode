﻿using Stratis.SmartContracts;

[Deploy]
public class StorageDemo : SmartContract
{
    public StorageDemo(ISmartContractState state) : base(state)
    {
        Counter = 12345;
        TestSave = "Hello, smart contract world!";
        Owner = Message.Sender;
    }

    public int Counter
    {
        get
        {
            return PersistentState.GetInt32("Counter");
        }
        set
        {
            PersistentState.SetInt32("Counter", value);
        }
    }

    public string TestSave
    {
        get
        {
            return PersistentState.GetString("TestSave");
        }
        set
        {
            PersistentState.SetString("TestSave", value);
        }
    }

    public Address Owner
    {
        get
        {
            return PersistentState.GetAddress("Owner");
        }
        set
        {
            PersistentState.SetAddress("Owner", value);
        }
    }

    public void Increment()
    {
        Counter++;
    }
}
