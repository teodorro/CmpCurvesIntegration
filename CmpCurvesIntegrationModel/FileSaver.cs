namespace CmpCurvesIntegrationModel
{
    public interface IFileSaver
    {
        bool OpenFileAfterSaving { get; set; }
        void SaveCmpScanTxt(string file);
        void SaveCmpScanXls(string file);
        void SaveLayersTxt(string file);
        void SaveLayersXls(string file);
        void SavePicturePng(string file);
    }

    public class FileSaver : IFileSaver
    {
        public bool OpenFileAfterSaving { get; set; }
        public void SaveCmpScanTxt(string file)
        {
            throw new System.NotImplementedException();
        }

        public void SaveCmpScanXls(string file)
        {
            throw new System.NotImplementedException();
        }

        public void SaveLayersTxt(string file)
        {
            throw new System.NotImplementedException();
        }

        public void SaveLayersXls(string file)
        {
            throw new System.NotImplementedException();
        }

        public void SavePicturePng(string file)
        {
            throw new System.NotImplementedException();
        }
    }
}