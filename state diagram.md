
## Statechart Diagram

A statechart diagram is made up of three main elements:

1. **State**: Represents the current condition of an object.
2. **Transition**: Shows that an object switches state.
3. **Event**: Occurs when a user triggers a transition.

### Initial State

![[side_5_statediagram.PNG]]

The diagram starts with an initial state, represented as a black circle. The node then has a flow to the beginning state of the object (Uninitialized).

### Events and Guard Conditions

The state then has events which trigger based on the given guard conditions. This leads to the final state outcome.

### Transition to Completed Node
![[side_5_statediagram1.PNG]]
The state then transitions to the completed node which will trigger the delete event, causing the end of the statechart. This represents the final state of the object after all events and transitions.

