Welcome to the project! Thanks for checking it out.

This is a demo / reproduction of a potential bug I have encountered in Zenject.

Here's a timeline of what happens:

- Editor starts

- Project context is created by Extenject, and binds its "Popup Parent" transform to the Project Context

- "Primary Scene" is loaded, and binds / instantiates a "Scene Changer" class

- The "Scene Changer" class waits 3 seconds, and then loads the next scene called "Secondary Scene"

- The "Secondary Scene" binds / instantiates a class called "HelloWorldPopUpController", which is responsible for creating a new prefab called "HelloWorldPopUpView"

The prefeab called "HelloWorldPopUpView" has a MonoBehaviour class on it by the same name, and has marked its controller ("HelloWorldPopUpController") to be a dependency

- Since the "HelloWorldPopUpView" prefab has a "ZenjectAutoInjecter" component attached to it, it should look in its hierarchy and tell the SceneContext container (populated by "SecondarySceneInstaller") to re-inject into the attached MonoBehaviour

- Observe that an exception is thrown:

ZenjectException: Unable to resolve 'HelloWorldPopUpController' while building object with type 'HelloWorldPopUpView'. Object graph:
HelloWorldPopUpView

The "HelloWorldPopUpView" seems to not be able to receive dependencies that are bound in the scene that it is being instantiated in. The same behavior appears when a "PlaceholderFactory<T>" is used to create the MonoBehaviour

