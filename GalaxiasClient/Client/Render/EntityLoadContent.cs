using System.Collections.Generic;
using ClientGalaxias.Client.Resource;
using Galaxias.Core.World.Entities;
using Galaxias.Util;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace ClientGalaxias.Client.Render;
public class EntityLoadContent
{
    private readonly Dictionary<EntityType, Texture2D> entityToTexture = new Dictionary<EntityType, Texture2D>();
    public void LoadContent(TextureManager manager)
    {
        foreach (var entityId in EntityTypes.entityRegister)
        {
            entityToTexture.Add(entityId.Value, manager.LoadTexture2D("Textures/Entities/" + entityId.Key));
        }
    }
}