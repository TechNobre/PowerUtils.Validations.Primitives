namespace PowerUtils.Validations.Primitives.Tests.Fakes;

public class FakeObj<TValue>
{
    public TValue Min { get; set; }
    public TValue Max { get; set; }

    public FakeObj(TValue min, TValue max)
    {
        Min = min;
        Max = max;
    }

    public (string minFormatted, string maxFormatted) GetFormatted()
        => (
            ErrorCodes.GetMinFormatted(Min),
            ErrorCodes.GetMaxFormatted(Max)
        );
}
