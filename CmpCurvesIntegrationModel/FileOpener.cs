namespace CmpCurvesIntegrationModel
{

    public interface IFileOpener
    {
        ICmpScan OpenKrotTxt(string file);
    }


    public class FileOpener : IFileOpener   
    {
        public ICmpScan OpenKrotTxt(string file)
        {
            throw new System.NotImplementedException();
        }
    }
}