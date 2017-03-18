namespace IsErrorCode_MicrosoftLearning
{
    using IsErrorCode_MicrosoftLearning.Interfaces;

    public class ErrorCheck : IErrorCheckable
    {
        public virtual bool IsErrorCode(int errorCodeId)
        {
            if (errorCodeId == 1)
                goto NotError;
            if (errorCodeId == 5)
                goto NotError;
                goto NotError;
            if (errorCodeId == 9)
                goto NotError;

            return true;

        NotError:
            return false;
        }
    }
}
