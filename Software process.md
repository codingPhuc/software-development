A structured set of activities required to develop a software system 

Many different software process but all involve : 
- Specification -defining what the system should do 
- design and implementation - defining the organization of the system and implementing the system 
- Validation -checking that it does what the customer wants 
- Evolution - changing the system in response  to changing customer need 
# Different type of programming approach 
Non-Structured Programming, Structured Programming, and Object-Oriented Programming (OOP) are all paradigms in the field of computer programming. They represent different methodologies for organizing and structuring code in a software program [[Programming approach]]  

# Software process descriptions 
When we describe and discuss processes , we usually talk about the activities in these processes such as specifying a  **data model , designing a user interface** , etc  . and the **ordering of these activities** 
Process description may also include : 
- **Products** ,, which are the outcomes of a process activity ; 
- **Roles** , which reflect the responsibilities of the people involved in the process ;
**- Pre and post condition** which are **statement** that are used before and after a process activity has been enacted or a product produced 

# Plan-driven and agile processes 
Plan-driven processes are processes where all of the process activities are **planned in advance and progress is measured against this plan** 
In [[Agile Process]] , planning is incremental and it is easier to change the process to reflect changing customer requirements 
In practice , most practical processes include element of both plan-driven and agile approaches 
there are no right or wrong software processes  there  are different [[Software process models]] bases on Plan-driven and agile process  

The Waterfall model is more rigid than Agile. If a project is uncertain, then Agile is more suitable. However, if the requirements are clear and unlikely to change, the Waterfall model is more acceptable.

# Software specification 
The process of establishing what services are required and the constraints on the system operation and development 
Requirements engineering process 
Feasibility study 
- is it technically and financially feasible to build the system ? 
Requirement elicitation and analysis 
- what do the system stakeholder require or expect form the system ? 
Requirement specification 
- Defining the requirements in detail 
Requirement validation 
- Checking the validity of the requirement 
![[side_2_therepireenginneringprocess.PNG]]
# Software design and implementation 

The process of converting the system specification into an executable system 
Software design 
- Design a software structure that realises the specification ; 
Implementation 
- Translate this structure into an executable programe 
The activities of design  and implementation are closely related and may be inter leaved 

A general model of the design process  

![[side_2_designprocess.PNG]]

## Design activities  
Architectural design , where you identify the overall  structure of the systems , the principal components (sometimes called sub systems or modules ) their relationship and how they are distributed 

**Interface design** , where you define the interface between system  components 
**Component design** , where you take each system component and design  how it will operate 
**Database design** , where you design the system data structure and how these are to be represented in a database 
# Software validation 
Verification and validation (V & V) is intended to show that a system conforms to its specification and meets the requirement of system customer 
Involves **Checking and review processes and system testing** 
System testing involves executing the system with test cases that are derived from the specification of the real data to be processed by the system 
Testing is the most commonly used V & V activity 
## Stage of testing 
![[side_2_stageoftesting.PNG]]
Development or component testing 
- Individual component are tested independently 
- Components may be **function** or **object** or **coherent** grouping 
System testing 
 - Testing of the system as a  whole . Testing of emergent properties is particular  important 
Acceptance testing 
- Testing with customer data to check that the system meets the customer needs 
![[side_2_plandriven.PNG]]
# Software evolutions 

Software is inherently flexible and can change 
as requirement change through changing business circumstances , the software that support the business much also evolve and change 
![[software changes.PNG]]
### key points 
Software process are activity involved in  producing a software system  . Software process models are abstract representation of these processes 

General process models **describe the organization of software processes** . Example of these general models include the the 'waterfall' model , increment development and reused oriented development 

**Requirement engineering** is the process of  developing a software specification 
**Design and implementation** processes are concern with transforming a requirement **specification** into an executable software 
**Software validation** is the process of checking if the software conform to its
**specification** and it meets the real need of it **user** of the system 

# Reducing costs of rework 
Change avoidance , where the software process includes activities that can anticipate possible changes before significant rework is required 
- For example , a [[prototype system]] can be developed to show some key feature of it system to the customer 
Change tolerance , where process is design so change can be develop at a relative cost 
- This normally involves some form  of [[increment development]] propose change may be implemented in increment that have not yet been developed . If this is impossible , then only a **single increment** (a small part of the system )  may have to be alter to incorporate the change 






