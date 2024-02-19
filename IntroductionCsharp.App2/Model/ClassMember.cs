namespace IntroductionCsharp.App2.Model;

/// <summary>
/// Membre d'une classe
/// </summary>
internal class ClassMember
{
    /// <summary>
    /// Nom de famille
    /// </summary>
    public string LastName { get; set; }

	/// <summary>
	/// Obtient ou défini le prénom
	/// </summary>
	public string FirstName { get; set; }

    /// <summary>
    /// Propriété calculée permettant d'obtenir le nom complet.
    /// </summary>
    public string FullName => LastName + " " + FirstName;

    /// <summary>
    /// Constructeur de la classe
    /// </summary>
    /// <param name="lastName">Nom de famille à renseigner</param>
    /// <param name="firstName">Le prénom à renseigner</param>
    public ClassMember(string lastName, string firstName)
    {
        LastName = lastName;
        FirstName = firstName;
    }


}
