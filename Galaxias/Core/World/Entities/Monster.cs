using Galaxias.Core.World;
using Galaxias.Core.World.Entities;

namespace Galasias.Core.World.Entities;
public class Monster : LivingEntity
{
    public Monster(AbstractWorld world, EntityType entityType) : base(world, entityType)
    {
    }
}