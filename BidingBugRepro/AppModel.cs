using Uno.Extensions.Reactive;
using Uno.Extensions.Reactive.Core;

namespace BindingBugRepro.Models;

/// <summary>
/// This is the application's MVUX model, with only the text that should be bound to the button.
/// However, in <see cref="MainPage"/>, the button's content is blank, because binding fails.
/// You should see a BindingExpression path error in Debug.
/// </summary>
[ReactiveBindable]
public partial record AppModel
{
    public IState<string> ExampleText => State.Value(this, () => "Example");
}
