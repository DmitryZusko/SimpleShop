namespace SimpleShop.Models.Services.DatabaseServices
{
    using AutoMapper;
    public interface IDatabaseService
    {
        public MapperConfiguration QuerybleConfig { get; }

        public TDestination Map<TSource, TDestination>(TSource source);
    }
}
