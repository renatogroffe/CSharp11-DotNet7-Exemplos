namespace ExemploGenericAttributes;

[AttributeUsage(AttributeTargets.Class)]
public class DocumentAttribute<T> : Attribute
{
    public Type Document { get; set; }

    public DocumentAttribute()
    {
        Document = typeof(T);
    }
}