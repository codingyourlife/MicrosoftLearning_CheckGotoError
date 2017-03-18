namespace IsErrorCode_MicrosoftLearning
{
    using IsErrorCode_MicrosoftLearning.Interfaces;

    public class ErrorCheckRefactored : ErrorCheck, IErrorCheckable
    {
        public override bool IsErrorCode(int errorCodeId)
        {
            return false;
        }
    }
}
