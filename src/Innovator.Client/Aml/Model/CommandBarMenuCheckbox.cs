using Innovator.Client;
using System;

namespace Innovator.Client.Model
{
  ///<summary>Class for the item type CommandBarMenuCheckbox </summary>
  public class CommandBarMenuCheckbox : Item, ICommandBarItem
  {
    protected CommandBarMenuCheckbox() { }
    public CommandBarMenuCheckbox(ElementFactory amlContext, params object[] content) : base(amlContext, content) { }
    static CommandBarMenuCheckbox() { Innovator.Client.Item.AddNullItem<CommandBarMenuCheckbox>(new CommandBarMenuCheckbox { _attr = ElementAttributes.ReadOnly | ElementAttributes.Null }); }

    /// <summary>Retrieve the <c>additional_data</c> property of the item</summary>
    public IProperty_Text AdditionalData()
    {
      return this.Property("additional_data");
    }
    /// <summary>Retrieve the <c>image</c> property of the item</summary>
    public IProperty_Text Image()
    {
      return this.Property("image");
    }
    /// <summary>Retrieve the <c>label</c> property of the item</summary>
    public IProperty_Text Label()
    {
      return this.Property("label");
    }
    /// <summary>Retrieve the <c>name</c> property of the item</summary>
    public IProperty_Text NameProp()
    {
      return this.Property("name");
    }
    /// <summary>Retrieve the <c>on_click_handler</c> property of the item</summary>
    public IProperty_Item<Method> OnClickHandler()
    {
      return this.Property("on_click_handler");
    }
    /// <summary>Retrieve the <c>on_init_handler</c> property of the item</summary>
    public IProperty_Item<Method> OnInitHandler()
    {
      return this.Property("on_init_handler");
    }
    /// <summary>Retrieve the <c>parent_menu</c> property of the item</summary>
    public IProperty_Item<CommandBarMenu> ParentMenu()
    {
      return this.Property("parent_menu");
    }
  }
}