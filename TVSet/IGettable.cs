namespace TVSet
{
    internal interface IGettable
    {      
        bool GetNextChannel();
        int  GetChannel();
        void SetNumberButton(int currentButton);
    }
    internal interface IGetButtonable
    {
        bool GetNextButton();
        int NumberButtonReturn();        
    }

}