using System;

public class Account
{
    private int id;
    private decimal balance;
    private string owner;
    private int numXact;
    public string GetStatement()
    {
        string s = "Owner = " + owner + ", Id = " + id + ", Transactions = " + numXact + ", Balance = " + balance;
        return s;
    }
}