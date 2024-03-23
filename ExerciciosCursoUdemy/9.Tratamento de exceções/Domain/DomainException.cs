namespace ExerciciosCursoUdemy._9.Tratamento_de_exceções.Domain;
class DomainException : ApplicationException
{
    public DomainException(string message) : base(message)
    {
    }
}
