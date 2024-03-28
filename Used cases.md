[[Used cases]] are technique  for capturing the **functional requirement** of a System .Use cases work by describing the typical **interaction** between the user of the system and system itself , providing a  narrative of how a system is used 

²A scenario: “The customer browses the catalog and adds desired items to the shopping basket. When the customer wishes to pay, the customer describes the shipping and credit card information and confirms the sale. The system checks the authorization an the credit card and confirms the sale both immediately and with a follow-up e-mail”



This  scenario is one thing that can happen . **However , the credit card authorization might fail , and this would be a separate scenario** 

**in another cases you might have regular customer , that you don't have to capture credit card and shipping information this is a third scenario** 
In all of these scenario the user have the same goal : of buying a product the user doesn't always succeed  , but the goal remains . This user goal is the key to use cases : **A used cases is a set of scenario tie together by a common user goal** 

## Actor  
Each use case have a **primary actor** ,which call on the system to deliver a service 
The primary actor is the actor with the goal the use case is trying to satisfy and is usually ,but not always , the initiator of the used cases 
There may be other actor that the which the system communicate which while carrying out the user cases , these is known as **secondary actor** 

There is **no standard way of write the content of the used cases ** , and different format work well in different cases** 
you begin  by picking one of the scenario as the main success scenario 
you start the body of the used cases by writing the main success scenario as a sequence of number of step 
you then take the other scenario and write them as extension 



# Use cases diagram - Relationship 
Actor relationship generalization 
- Used to define overlapping roles between actors  

Actor -Use cases relationship 
- Association
![[actor.PNG]]

Use case Relationship 
- include 
- Extend 
- Generalization / Specification 
![[side_3_usedcases.PNG]]

## Association 
**Relationship between actor and used case** 
Actor is involved in interaction describe by the user
if association line has arrow head : 
- indicate direction of invocation , primary actor 
- indicate control flow (not data flows)
![[side_3_association.PNG]]
### include : 
directed relationship between 2 used cases 
![[side_3_include.PNG]]
### extends 
Behavior of extension use case may be inserted in extended use case under some conditions 
![[side_3_extend.PNG]]