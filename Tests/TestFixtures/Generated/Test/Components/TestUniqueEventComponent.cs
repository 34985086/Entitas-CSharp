//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestContext {

    public TestEntity uniqueEventEntity { get { return GetGroup(TestMatcher.UniqueEvent).GetSingleEntity(); } }
    public UniqueEventComponent uniqueEvent { get { return uniqueEventEntity.uniqueEvent; } }
    public bool hasUniqueEvent { get { return uniqueEventEntity != null; } }

    public TestEntity SetUniqueEvent(string newValue) {
        if (hasUniqueEvent) {
            throw new Entitas.EntitasException("Could not set UniqueEvent!\n" + this + " already has an entity with UniqueEventComponent!",
                "You should check if the context already has a uniqueEventEntity before setting it or use context.ReplaceUniqueEvent().");
        }
        var entity = CreateEntity();
        entity.AddUniqueEvent(newValue);
        return entity;
    }

    public void ReplaceUniqueEvent(string newValue) {
        var entity = uniqueEventEntity;
        if (entity == null) {
            entity = SetUniqueEvent(newValue);
        } else {
            entity.ReplaceUniqueEvent(newValue);
        }
    }

    public void RemoveUniqueEvent() {
        uniqueEventEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public UniqueEventComponent uniqueEvent { get { return (UniqueEventComponent)GetComponent(TestComponentsLookup.UniqueEvent); } }
    public bool hasUniqueEvent { get { return HasComponent(TestComponentsLookup.UniqueEvent); } }

    public void AddUniqueEvent(string newValue) {
        var index = TestComponentsLookup.UniqueEvent;
        var component = CreateComponent<UniqueEventComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceUniqueEvent(string newValue) {
        var index = TestComponentsLookup.UniqueEvent;
        var component = CreateComponent<UniqueEventComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveUniqueEvent() {
        RemoveComponent(TestComponentsLookup.UniqueEvent);
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
public sealed partial class TestMatcher {

    static Entitas.IMatcher<TestEntity> _matcherUniqueEvent;

    public static Entitas.IMatcher<TestEntity> UniqueEvent {
        get {
            if (_matcherUniqueEvent == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentsLookup.UniqueEvent);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherUniqueEvent = matcher;
            }

            return _matcherUniqueEvent;
        }
    }
}
