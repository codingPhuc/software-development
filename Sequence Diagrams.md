
 [[Sequence Diagrams]] **Interactive diagram describe how group of object collaborate in some behavior** . The UML define server form of UML one of which is sequence diagram 
Typically , a sequence  diagram captures the **behavior of a single scenario**. The diagram show a number of example object and the message that are passed between these object within the use case 

²We have an order and are going to invoke a command on it to calculate its price

²To do that, the order needs to look at all the line items on the order and determine their prices, which are based on the pricing rules of the order line's products. Having done that for all the line items, the order then needs to compute an overall discount, which is based an rules tied to the customer
![[side_3_sequencediagarm.PNG]]
# A sequence diagram for centralized control 
Sequence diagram show the interaction by showing by showing a life line that run vertically down the page and ordering of message which run down the page 
you can see that an instance of order send getQuatity and get product message to the order line . you can also see how we show the order invoking a method an itself and how that method send getDiscountInfo to an instance of customer 

Most of the items , you can think of the paritcipant in a interaction diagram as object , as indeed they were in UML 1 . But in UML2 ,thier role are much more complicated 

In the diagram , I have named the participant  using the style anOrder  . This work well most of the time . A fuller Syntax is name : Class , where both the name and the class are optional 


Each lifeline has an **activation bar** which show when a participant is active in the interaction . this correspond to one of the participant method being on the stack . Activation bar are optional in UML , but I find them extremly valuable in clarifying the behavior 

Naming often is useful to correlate participant an the diagrame .The call getProduct is shown returning aProduct , which is the same name , and therefore the same participant 
Some people used return for all call , but I prefer to use them only where they add information 

# A sequence diagram for distributed control 

![[side_3_sequencediagrame.PNG]]

the different between the Centralize control vs distributed control is that the centralize control there is **one participant doing all the process** and other participant there to supply the data . distributed control on the other hand **split among many participant**  each one doing a little bit of the algorithm 

# centralize vs distributed control 
Both style have there own strength and weakness 
most people , particularly those new to object , are more used to centralized control . In many ways , it simpler , as all the processing is in one place 
With distributed control , in contrast ,you have the sensation of chasing around the object trying to find the program 
²One of the main goals of good design is to localize the effects of change. Data and behavior that accesses that data often change together. So putting the data and the behavior that uses it together in one place is the first rule of object-oriented design.

²By distributing control, you create more opportunities for using polymorphism rather than using conditional logic . If the algorithms for product pricing are different for different types of product, the distributed control mechanism allows us to use subclasses of product to handle these variations

# when to used a sequence Diagrams 
You should use a sequence diagram when you want to look at the behavior of server object within a single used cases 
Sequence diagram are good at showing collaboration among the object ; they are not so good at precise definition of the behavior 
if you want to look at the behavior of a **single object thought multiple used cases used the state diagram** 
if you want to look at **behavior across many use cases or many threads , consider an activity diagram** 

