namespace ClientGalaxias.Client.Render.EntityRenders;
public class PlayerRenderer : EntityRenderer{
    public PlayerRenderer(float width, float height) : base(width, height)
    {
    }

    public override string GetTexture()
    {
        return "Textures/Entities/player";
    }

}