using Domain.Primitives;

namespace Domain.Destinations;

public sealed class Destination : AggregateRoot

{
   public DestinationId Id {get; private set; }

   public string Name {get; private set;} = string.Empty;

   public string Location {get; private set ;} =string.Empty;

   public Destination()
   {

   }

   public Destination(DestinationId id, string name, string location)
   {
      Id = id;
      Name = name;
      Location = location;
   }

   public static Destination UpdateDestination(Guid Id, string name, string location)
   {
     return new Destination(new DestinationId(id), name, location);
   }


}