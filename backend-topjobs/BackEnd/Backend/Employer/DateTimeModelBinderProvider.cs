public class DateTimeModelBinderProvider : IModelBinder
{
    public IModelBinder GetBinder(ModelBinderProviderContext context)
    {
        if (DateTimeModelBinder.SUPPORTED_TYPES.Contains(context.Metadata.ModelType))
        {
            return new BinderTypeModelBinder(typeof(DateTimeModelBinder));
        }

        return null;
    }
}
