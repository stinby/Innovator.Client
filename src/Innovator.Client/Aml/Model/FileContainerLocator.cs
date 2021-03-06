using Innovator.Client;
using System;

namespace Innovator.Client.Model
{
  ///<summary>Class for the item type FileContainerLocator </summary>
  [ArasName("FileContainerLocator")]
  public class FileContainerLocator : Item
  {
    protected FileContainerLocator() { }
    public FileContainerLocator(ElementFactory amlContext, params object[] content) : base(amlContext, content) { }
    static FileContainerLocator() { Innovator.Client.Item.AddNullItem<FileContainerLocator>(new FileContainerLocator { _attr = ElementAttributes.ReadOnly | ElementAttributes.Null }); }

    /// <summary>Retrieve the <c>container_id</c> property of the item</summary>
    [ArasName("container_id")]
    public IProperty_Item<IFileContainerItems> ContainerId()
    {
      return this.Property("container_id");
    }
    /// <summary>Retrieve the <c>container_property_name</c> property of the item</summary>
    [ArasName("container_property_name")]
    public IProperty_Text ContainerPropertyName()
    {
      return this.Property("container_property_name");
    }
    /// <summary>Retrieve the <c>container_type_id</c> property of the item</summary>
    [ArasName("container_type_id")]
    public IProperty_Item<ItemType> ContainerTypeId()
    {
      return this.Property("container_type_id");
    }
    /// <summary>Retrieve the <c>file_id</c> property of the item</summary>
    [ArasName("file_id")]
    public IProperty_Item<File> FileId()
    {
      return this.Property("file_id");
    }
  }
}