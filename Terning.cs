using System;

public class Terning
{
	public int Værdi;
    public Terning()
	{
        this.Værdi = new Random().Next(1, 7);
	}

    public Terning(int tal)
    {
        this.Værdi = tal;
    }
}
