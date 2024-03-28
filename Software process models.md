**The waterfall model**
- Plan-driven model . Separate and distinct phases of specification and development  
**Incremental development**
- Specification , development and validation are interleaved 
**Reused-oreiented software engineering**
- The system is assembled form existing components May be plan drivent or agile 
In practice , most large systems are developed using a process that incorporates element from all of these models 
# The waterfall model 


## The waterfall model 
![[side_2_waterfall.PNG]]

There are separate identified phases in the waterfall models : 
- requirements analysis and definition 
- System and software design 
- Implementation and unit testing 
- integration and system testing 
- Operation and maintenance 

The main draw back of the waterfall model is the **difficulty of accommodating** change after the process is underway . In  principle  , a phase has to be complete before moving onto the  next phase 
### Waterfall model problems 
Inflexible partitioning of the project into distinct stages make it difficult to respond to changing customer requirements 
- Therefore , this model is only appropriate when the requirement s are **well-understood** and changes will be fairly limited during the design process 
- few business systems have stable requirement 
The waterfall model is mostly used for large systems engineering  project where a system is developed at several sites 
- in those circumstance , the plan driven nature of the waterfall model helps coordinate the work 

# Incremental development 



![[side_2_increment.PNG]]
### Incremental development benefits 
The cost of accommodating changing customer requirement is reduced 
- The amount of analysis and documentation that has to be redone is much less than is required with the waterfall model 
It is easier to get customer feedback on the development work that has been done 
- Customer can comment on demonstrations of the software and see how much can has been implemented 
**More rapid delivery** and deployment of useful software to the customer is possible 
- Customer are able to use and gain value from  the software earlier than it is possible with the waterfall process 

### Incremental development problems 
System structure tend to degrade as new increments are added 
- Unless time and money are spend on refactoring the software , regular change tends to corrupts its structure . Incorporating further software changes become increasingly difficult and costly 


# Reuse oriented software engineering 
Based on systematic reuse the system are integrated from exiting components or COTS (Commercial-off-the-shelf) systems 
Commercial-off-the-shelf : **A software and/or hardware product that is commercially ready-made and available for sale, lease, or license to the general public**.
Process stages  
- Component analysis 
- Requirement modification 
- System design with reuse 
- Development and integration 
Reuse is now the standard approach for building many types of business system 

![[side_2_resused.PNG]]
Web services that are developed according to service standard and which are available for remote invocation 
collection of objects that are develped as a package to be integrated with a component framework such as .NET or J2EE 
Stand alone software system(COTS) that are configured for use  in particular environment 

