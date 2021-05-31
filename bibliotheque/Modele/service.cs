using System;

public class Service
{
	private int idservice;
	private string nom;


	public int Idservice { get => idservice; }
	public string Nom { get => nom; }

	public Service(int idservice, string nom)
	{
		this.idservice = idservice;
		this.nom = nom;
	}

	/// <summary>
	/// definit l'info a afficher
	/// </summary>
	/// <returns>nom du service</returns>
	public override string ToString()
	{
		return this.nom;
	}
}
