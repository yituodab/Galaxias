using System.Collections.Generic;

namespace Galaxias.Core.World.Entities;
public class EntityTypes
{
    public static readonly Dictionary<string, EntityType> entityRegister = new Dictionary<string, EntityType>();
    public static readonly EntityType PlayerEntity = Register("player", new EntityType());
    private static EntityType Register(string name, EntityType entityType)
    {
        entityRegister.Add(name, entityType);
        return entityType;
    }
}
