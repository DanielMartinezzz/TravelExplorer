namespace Domain.Destinations;

public interface DestinatarionRepository
{
   Task<List<Destination>> GetAll();

   Task<Destination?> GetByIdAsync(DestinationId id);

   void Add(Destination destination);

   void Update(Destination destination);

   void Delete(Destination destination);
}