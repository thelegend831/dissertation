public struct Frame
{
    public List<Single> Vertices;
    public List<byte> RGB;
    public List<Body> Bodies;
    public int ClientID;
    public List<AffineTransform> CameraPoses;

    public Frame(List<Single> vertsin, 
                    List<byte> rgbin, 
                    List<Body> bodiesin, 
                    int clientID, 
                    List<AffineTransform> cameraPosesin)
    {
        Vertices = vertsin;
        RGB = rgbin;
        Bodies = bodiesin;
        ClientID = clientID;
        CameraPoses = cameraPosesin;
    }
}