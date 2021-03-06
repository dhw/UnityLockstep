//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public NavigationInputDataComponent navigationInputData { get { return (NavigationInputDataComponent)GetComponent(InputComponentsLookup.NavigationInputData); } }
    public bool hasNavigationInputData { get { return HasComponent(InputComponentsLookup.NavigationInputData); } }

    public void AddNavigationInputData(int[] newEntityIds, BEPUutilities.Vector2 newDestination) {
        var index = InputComponentsLookup.NavigationInputData;
        var component = (NavigationInputDataComponent)CreateComponent(index, typeof(NavigationInputDataComponent));
        component.EntityIds = newEntityIds;
        component.Destination = newDestination;
        AddComponent(index, component);
    }

    public void ReplaceNavigationInputData(int[] newEntityIds, BEPUutilities.Vector2 newDestination) {
        var index = InputComponentsLookup.NavigationInputData;
        var component = (NavigationInputDataComponent)CreateComponent(index, typeof(NavigationInputDataComponent));
        component.EntityIds = newEntityIds;
        component.Destination = newDestination;
        ReplaceComponent(index, component);
    }

    public void RemoveNavigationInputData() {
        RemoveComponent(InputComponentsLookup.NavigationInputData);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherNavigationInputData;

    public static Entitas.IMatcher<InputEntity> NavigationInputData {
        get {
            if (_matcherNavigationInputData == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.NavigationInputData);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherNavigationInputData = matcher;
            }

            return _matcherNavigationInputData;
        }
    }
}
