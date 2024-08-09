using System.Collections.Generic;
using ClientGalaxias.Client.Render;
using ClientGalaxias.Client.Render.EntityRenders;

namespace Galaxias.Core.World.Entities;
public class EntityRenderers
{
    public static readonly Dictionary<EntityType, EntityRenderer> entityRendererRegister = new Dictionary<EntityType, EntityRenderer>();
    public static readonly EntityRenderer PlayerRenderer = Register(EntityTypes.PlayerEntity, new PlayerRenderer(2,4));
    private static EntityRenderer Register(EntityType entityType, EntityRenderer renderer)
    {
        entityRendererRegister.Add(entityType, renderer);
        return renderer;
    }
}
