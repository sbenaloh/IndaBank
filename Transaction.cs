using System;

public class Transaction
{
    private DateTime date;
    private Double amount;
    private String category;    // Storing as String for now, can be more concrete if desirable.

	public Transaction(DateTime date, Double amount, String category)
	{
        this.date = date;
        this.amount = amount;
        this.category = category;
	}
}
