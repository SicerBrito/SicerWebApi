namespace Dominio.Interfaces;
    public interface IUnitOfWork
    {
        ICiudad ? Ciudades { get; }
        IDepartamento ? Departamentos { get; }
        IDireccion ? Direcciones { get; }
        IGenero ? Generos { get; }
        IMatricula ? Matriculas { get; }
        IPais ? Paises { get; }
        IPersona ? Personas { get; }
        ISalon ? Salones { get; }
        ITipoDocumento ? TiposDeDocumentos { get; }
        ITipoPersona ? TiposDePersonas { get; }
        ITipoVia ? TipoDeVias { get; }
        ITrainerSalon ? TrainersDeSalones { get; }
        Task<int> SaveAsync();
    }
