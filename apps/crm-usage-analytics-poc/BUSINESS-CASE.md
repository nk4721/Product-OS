# Business Case: CRM Usage Analytics for SuperOffice

## Document status

- Product: CRM Usage Analytics for SuperOffice
- Stage: Proof of concept / discovery
- Decision owner: Human Product Owner
- Coordinating role: Product Director
- Contributors: Discovery, Business Analyst & Finance, Customer Intelligence, Product Marketing, Technical Architect, Data & AI, Customer Success and Sales Enablement
- Last updated: 2026-07-14

---

## 1. Executive summary

CRM Usage Analytics is a proposed analytics product that helps organisations understand how consistently SuperOffice CRM is used across users and teams.

The product converts CRM activity data into practical adoption indicators, such as active and inactive users, usage by team, activity trends and an overall Adoption Score. The intended outcome is to help sales leaders, CRM owners and management identify adoption gaps, target training and process improvements, and protect the value of their CRM investment.

The existing proof of concept demonstrates the intended dashboard and scoring concept using demo data. Before commercial development is approved, the team must validate which relevant activity signals are reliably available through SuperOffice APIs and whether target customers will pay for recurring adoption analytics.

### Recommendation

Proceed with a limited discovery and pilot phase rather than full product development.

Approve further investment only when the following conditions are met:

1. Required activity data can be obtained reliably and lawfully.
2. At least five target customers confirm that the problem is important.
3. At least three customers agree to participate in a pilot.
4. At least two pilot customers demonstrate willingness to pay.
5. A first version can be delivered without employee-surveillance features or excessive implementation work.

---

## 2. Customer problem

Many organisations invest significantly in CRM licences, implementation, integrations, training and process development, but have limited visibility into whether employees use the CRM consistently and correctly.

Typical questions are difficult to answer:

- Which users and teams are actively using the CRM?
- Is usage improving or declining?
- Are important customer activities being documented?
- Which teams need training or management support?
- Is low CRM adoption reducing data quality and forecast reliability?
- Is the organisation receiving sufficient value from its CRM investment?

Existing reporting often focuses on business outcomes, such as sales and activities, rather than adoption behaviour. Manual analysis is time-consuming and may not provide consistent comparisons over time.

---

## 3. Target customers and users

### Primary customer segment

Medium-sized and larger SuperOffice customers with:

- approximately 20 or more CRM users
- several sales or customer-facing teams
- an internal CRM owner, sales operations role or system administrator
- recurring concerns about adoption, data quality or process compliance
- an established investment in CRM implementation and training

### Primary users

- CRM owners and administrators
- Sales managers
- Sales operations and revenue operations
- Customer service managers
- Business process owners
- Management teams
- CRM consultants supporting adoption programmes

### Economic buyer

The economic buyer is likely to be one of the following:

- Sales Director
- COO
- CIO or IT Manager
- Head of Sales Operations
- Business Process Owner

---

## 4. Proposed value proposition

### Core value proposition

CRM Usage Analytics gives leaders an objective and actionable view of SuperOffice adoption so they can improve usage, data quality and return on their CRM investment.

### Customer outcomes

The product should help customers:

- identify inactive users and adoption gaps early
- compare teams using consistent measures
- focus training and coaching where it creates the most value
- track whether adoption initiatives produce results
- improve CRM data completeness and reliability
- strengthen sales-process compliance
- support fact-based conversations between management, users and CRM owners
- reduce dependence on manual reporting and consultant analysis

### Important positioning principle

The product should be positioned as an adoption and improvement tool, not as an employee-surveillance system.

Its primary purpose is to identify organisational patterns and support teams. Individual-level information should be configurable, role-restricted and used only where there is a legitimate business purpose.

---

## 5. Proposed solution

The first commercial version could include:

- overall CRM adoption summary
- active and inactive user trends
- adoption score by user and team
- team comparisons
- activity trends over selected periods
- configurable usage signals
- threshold-based warnings
- drill-down into the factors affecting a score
- exportable management reports
- recommendations for training or process improvement

Potential usage signals include:

- login or active-session history
- activities created or completed
- opportunities created or updated
- companies and contacts updated
- emails archived or logged
- notes created
- data completeness indicators

The final signal set depends on technical validation, data quality and privacy requirements.

---

## 6. Differentiation

The product can differentiate through:

- a specific focus on SuperOffice rather than generic analytics
- predefined adoption metrics that require limited customer configuration
- implementation and advisory expertise around SuperOffice processes
- explanations of why an Adoption Score changes
- links between usage patterns, training recommendations and process improvements
- benchmarking over time and, only where legally and commercially appropriate, anonymised peer benchmarks
- the ability to use the product as part of a recurring CRM success service

The strongest competitive advantage is unlikely to be the dashboard alone. It is the combination of SuperOffice-specific data, interpretation and actionable adoption guidance.

---

## 7. Strategic fit

The product fits a CRM consultancy and product organisation because it can:

- create recurring revenue after implementation projects
- strengthen long-term customer relationships
- provide evidence for training, optimisation and consulting services
- improve customer retention by increasing realised CRM value
- create a structured customer-success offering
- generate insight into common adoption problems that can influence future products

It also complements existing expertise in SuperOffice configuration, dashboards, processes, onboarding and customer success.

---

## 8. Business model and pricing hypotheses

Pricing is not yet validated. The team should test both a software-only offer and a software-plus-advisory service.

### Option A: Recurring SaaS subscription

Illustrative pricing hypothesis:

- Small: SEK 1,500-2,500 per month
- Medium: SEK 3,000-5,000 per month
- Large: SEK 6,000-10,000 per month

Pricing could be based on number of users, number of teams or customer size.

### Option B: Fixed implementation plus subscription

Illustrative hypothesis:

- Setup and configuration: SEK 15,000-40,000
- Recurring subscription: SEK 2,500-7,500 per month

### Option C: Adoption service

A higher-value package could combine the product with quarterly analysis, workshops and action plans.

Illustrative hypothesis:

- SEK 75,000-200,000 per year depending on customer size and service level

### Recommended initial commercial model

Test a paid pilot with:

- a limited setup fee
- a three-month pilot period
- a defined baseline and adoption review
- a conversion offer to an annual subscription

This tests both product value and advisory value while reducing the customer's initial commitment.

---

## 9. Financial scenarios

The following scenarios are planning assumptions, not forecasts. They exclude VAT and should be replaced when customer willingness to pay and delivery cost have been validated.

### Scenario assumptions

| Scenario | Paying customers | Average annual recurring revenue per customer | Annual recurring revenue |
|---|---:|---:|---:|
| Conservative | 10 | SEK 36,000 | SEK 360,000 |
| Base | 30 | SEK 60,000 | SEK 1,800,000 |
| Growth | 75 | SEK 84,000 | SEK 6,300,000 |

Possible additional setup and advisory revenue is excluded from this table.

### Preliminary cost categories

- product discovery and customer research
- SuperOffice API and data-access validation
- backend and frontend development
- data storage and hosting
- security, privacy and legal review
- monitoring and support
- onboarding and customer-success material
- sales and marketing
- ongoing maintenance when SuperOffice APIs change

### Indicative development assumption

A focused first commercial version may require approximately three to six person-months after successful technical validation. This is an early planning assumption and must be estimated by the Technical Architect and development team after the data-access spike.

### Break-even logic

Break-even depends primarily on:

- whether the product can use standardised data extraction across customers
- the amount of customer-specific configuration required
- ongoing support requirements
- achievable annual revenue per customer
- whether implementation and advisory services are charged separately

A viable product should avoid becoming a custom reporting project for every customer.

---

## 10. Benefits by stakeholder

### For the customer

- better visibility into CRM adoption
- improved value from existing licences
- more focused training investments
- stronger data quality
- earlier identification of adoption risks

### For sales and customer-facing managers

- team-level trends and comparisons
- evidence for coaching conversations
- ability to track improvement initiatives

### For CRM owners

- reduced manual reporting
- stronger mandate for governance and training
- objective evidence for prioritising improvements

### For the supplier

- recurring revenue
- stronger customer retention
- opportunities for consulting, training and optimisation
- improved understanding of customer usage challenges

---

## 11. Key risks and mitigations

### Risk: Required data is unavailable or incomplete

Mitigation:

- conduct a technical spike before further investment
- document each proposed signal and its source
- create a fallback score using only reliable signals

### Risk: The product is perceived as employee surveillance

Mitigation:

- lead with team improvement and customer value
- provide aggregated views by default
- implement role-based access and configurable individual views
- conduct privacy and employment-law review before launch
- avoid simplistic productivity rankings

### Risk: Adoption Score is misleading

Mitigation:

- make the score transparent and explainable
- allow weighting by role and process
- avoid comparing roles with fundamentally different CRM behaviours
- validate scoring with pilot customers

### Risk: Every customer requires custom configuration

Mitigation:

- define standard packages and supported signals
- use configuration rather than custom code
- charge separately for non-standard requirements

### Risk: Customers find existing SuperOffice reporting sufficient

Mitigation:

- validate the problem before building
- focus on longitudinal adoption, interpretation and recommendations
- compare the proposed offer with dashboards customers already use

### Risk: Managers do not act on the insights

Mitigation:

- provide recommended actions and review routines
- package the tool with customer-success or advisory services
- measure actions and improvement, not only dashboard usage

---

## 12. Data, privacy and ethical requirements

Before a pilot with real employee data, the team must define:

- the lawful basis and purpose for processing
- data controller and processor responsibilities
- data minimisation rules
- retention periods
- role-based access
- audit logging
- whether individual-level analysis is necessary
- requirements for employee information or consultation
- handling of customers in different jurisdictions

The product must not infer employee performance solely from CRM activity volume. Different roles, working patterns and customer processes create legitimate differences in activity data.

---

## 13. Validation plan

### Customer discovery

Interview at least ten SuperOffice customers across different sizes.

Validate:

- how they currently measure adoption
- the consequences of poor adoption
- existing reports and workarounds
- decision-making frequency
- preferred level of detail
- privacy concerns
- willingness to pay

### Technical validation

For every proposed usage signal, document:

- API or data source
- availability by SuperOffice version and licence
- historical depth
- reliability
- update frequency
- permissions required
- performance implications
- privacy classification

### Pilot validation

Run a pilot with three to five customers for approximately three months.

Measure:

- time required to configure each customer
- percentage of relevant users covered by reliable data
- manager engagement with the dashboard
- number of identified adoption actions
- measurable change in selected adoption indicators
- customer willingness to continue paying

---

## 14. Success metrics

### Discovery success

- ten completed customer interviews
- at least five customers rate the problem as important
- at least three pilot commitments
- documented willingness-to-pay evidence

### Product success

- reliable data for at least 80% of agreed core signals
- customer setup completed without custom development
- at least 70% of pilot managers use the product during monthly reviews
- customers can identify at least one actionable adoption improvement

### Commercial success

- at least two paid pilot conversions
- annual recurring revenue per customer supports profitable onboarding and support
- gross-margin target defined after infrastructure and support costs are known
- low customer-specific development requirement

### Customer outcome success

Depending on the customer's goals:

- reduction in inactive users
- increase in consistent activity logging
- improved completeness of selected CRM records
- improved adoption score over an agreed period
- reduced time spent producing manual usage reports

---

## 15. Delivery approach

### Phase 1: Problem and technical validation

Deliverables:

- interview findings
- validated problem statement
- data availability matrix
- privacy assessment
- initial pricing evidence
- updated go/no-go recommendation

### Phase 2: Pilot-ready MVP

Deliverables:

- secure customer connection
- standard adoption dashboard
- configurable score
- team-level analysis
- basic administration and access control
- pilot onboarding guide

### Phase 3: Paid pilots

Deliverables:

- customer baselines
- monthly adoption reviews
- documented actions and outcomes
- willingness-to-pay and renewal evidence

### Phase 4: Commercialisation

Only after successful pilots:

- standard subscription packages
- scalable onboarding
- support process
- security documentation
- sales enablement and product marketing
- product roadmap based on validated demand

---

## 16. Go/no-go decision criteria

### Proceed to pilot-ready MVP when

- technically reliable signals exist
- privacy risks are manageable
- at least three customers commit to a pilot
- customers confirm that current reporting does not solve the problem adequately
- expected pricing can support the operating model

### Stop or redesign when

- data extraction requires extensive customer-specific work
- reliable usage measures cannot be obtained
- the value depends mainly on monitoring individual employees
- customers show interest but no willingness to pay
- existing SuperOffice functionality solves the validated need sufficiently

---

## 17. Product-team conclusion

The opportunity is credible because CRM adoption is directly connected to data quality, process consistency and realised value from CRM investments. The concept also aligns well with SuperOffice consulting, customer success and optimisation services.

However, the business case is not yet proven. The greatest uncertainties are data access, customer willingness to pay, privacy expectations and the risk of customer-specific implementation work.

The team recommends a controlled investment in discovery, technical validation and paid pilots. Full commercial development should remain conditional on evidence from these stages.

---

## 18. Immediate next actions

1. Discovery Agent: prepare and conduct ten customer interviews.
2. Technical Architect: create a SuperOffice usage-signal availability matrix.
3. Customer Intelligence Agent: analyse existing customer feedback and adoption problems.
4. Business Analyst & Finance Agent: test pricing and refine the unit-economics model.
5. Data & AI Agent: define an explainable Adoption Score and identify bias risks.
6. Product Marketing Agent: test positioning focused on adoption improvement rather than monitoring.
7. Customer Success Agent: design a three-month pilot and monthly review process.
8. Product Director: evaluate the evidence and make the next go/no-go recommendation.
