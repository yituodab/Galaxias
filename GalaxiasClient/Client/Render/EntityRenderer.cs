using System.Collections.Generic;
using ClientGalaxias.Client.Resource;
using Galaxias.Core.World.Entities;
using Galaxias.Util;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace ClientGalaxias.Client.Render;
public class EntityRenderer
{
    public float width;
    public float height;
    public EntityRenderer(float width,float height){
        this.width = width;
        this.height = height;
    }
    public virtual string GetTexture(){
        return null;
    }
    
    public void Render(IntegrationRenderer renderer, float renderX, float renderY, Entity entity, int scale, Color colors)
    {
        //Texture2D entityTexture = entityToTexture.GetValueOrDefault();
        //if(entityTexture != null)
        renderer.Draw(this.GetTexture(), renderX - width * scale / 2, renderY - height * scale, colors,
            effects: entity.direction == Direction.Left ? SpriteEffects.FlipHorizontally : SpriteEffects.None);
                
    }
}
