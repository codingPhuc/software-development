
## Activity Diagram

An activity diagram is used to model the flow of activities in a system and the decisions that are made along the way for workflow and business processes. An activity diagram is made up of two main components:

- **Nodes**: Represent actions.
- **Flows**: Show the flow of control between actions.
![[side_5_activitydiagram.PNG]]
### Initial Node

The diagram starts with an initial node. The arrow between two nodes represents a flow.

### Decision Node

Upon reaching a decision node, it will have guard conditions. The guard conditions need to be exclusive.

### Merge Activity
![[side_5_activitydiagram1.PNG]]
After the conditional action, it can then be merged into a Merge activity.




![[side_5_activitydiagram2.PNG]]
### Parallelized Options

When an activity reaches parallelized options, the workflow is split into different actions represented by a black bar. This is like when a file is being downloaded and the system also sends you a downloaded email.

### Final Node

Then the actions will be merged into one by a black bar, with the final node being a white circle with a smaller circle inside. This represents the end of the activity flow.