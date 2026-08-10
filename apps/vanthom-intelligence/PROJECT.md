# Vanthom Intelligence

## Status

**Stage:** Intake / discovery  
**Type:** Customer-facing AI product concept  
**Primary owner:** Product Director  
**Reviewer:** Founder  
**Decision to enable:** Whether Vanthom Intelligence should proceed into validated product discovery.

## Concept

Vanthom Intelligence is a proposed AI-powered decision-support layer that turns approved business, product, customer and operational information into traceable insights, recommendations and next actions.

It is intended to help decision-makers move from fragmented information to a clear, evidence-based decision without hiding uncertainty or the source of a conclusion.

## Problem hypothesis

Product and business leaders often have relevant information spread across CRM, documents, product work, analytics and specialist systems. They spend time finding, reconciling and summarising that information before they can make a decision.

The working hypothesis is that the main problem is not lack of data, but lack of:

- context across approved sources
- a consistent way to separate facts from assumptions
- traceability from a recommendation back to evidence
- clear ownership of the next action
- reusable organisational learning

This problem has not yet been validated with target customers.

## Target users

Initial discovery should focus on:

- product leaders and product managers
- commercial and operational leaders
- CRM and customer-success leaders
- consultants responsible for analysis, recommendations and follow-up

The initial ideal customer profile remains an assumption until discovery identifies the segment with the clearest pain and willingness to pay.

## Value proposition hypothesis

Vanthom Intelligence helps teams make faster, better-supported decisions by combining governed context, specialist AI analysis and transparent evidence in one decision workflow.

Expected value hypotheses:

- less time spent gathering and summarising information
- clearer decisions and responsibilities
- more consistent analysis across teams
- fewer unsupported recommendations
- organisational learning that remains reusable after a project ends

## Product principles

1. **Evidence before confidence** — distinguish verified facts, interpretations, assumptions and recommendations.
2. **Traceable outputs** — show which approved sources support a conclusion.
3. **Human accountability** — AI may recommend; an accountable person approves material decisions.
4. **Purpose-limited access** — use only information the user and organisation are entitled to access.
5. **Supplier isolation** — never imply that licensed supplier data is interchangeable.
6. **Data minimisation** — retrieve and retain only what is needed for the agreed purpose.
7. **Actionable outcomes** — every analysis should enable a decision, action or learning.
8. **Measurable value** — success is customer outcome and decision quality, not message volume or raw AI usage.

## Candidate capabilities

These are discovery hypotheses, not committed scope:

- conversational questions across approved information sources
- decision briefs with facts, assumptions, risks and recommendations
- customer and product insight synthesis
- signal monitoring with explainable alerts
- guided workflows using specialist AI roles
- action and owner suggestions requiring human confirmation
- reusable decision and learning history
- source citations, permissions and audit trail

## Initial user journey

1. The user defines the decision or question.
2. Vanthom Intelligence identifies the approved context required.
3. The system retrieves only authorised information.
4. Specialist analysis separates evidence, assumptions and gaps.
5. The user receives a decision brief with sources, risks and options.
6. An accountable person approves, rejects or revises the recommendation.
7. The decision, owner and learning are recorded.

## Non-goals

Vanthom Intelligence is not intended to:

- become a generic data warehouse
- combine or silently substitute data from different commercial suppliers
- bypass customer contracts, permissions or source-system controls
- make high-impact decisions without accountable human approval
- present generated text as verified evidence
- duplicate the supplier-specific applications or the SuperOffice Integration SDK
- claim autonomous accuracy that has not been demonstrated

## Product and architecture boundary

Vanthom Intelligence is a separate customer-facing concept under `apps/`.

Supplier-specific API clients, credentials, entitlements and business rules remain inside their respective applications. Vanthom Intelligence may consume authorised outputs through explicit interfaces, but it must preserve source identity, contractual restrictions and tenant boundaries.

The existing Integration SDK is a SuperOffice-oriented internal foundation. It is not automatically a dependency of Vanthom Intelligence. Reuse should be introduced only when a real shared technical need is demonstrated.

## Risks and open questions

- Which recurring decision is painful enough to justify a product?
- Which initial segment has both urgency and buying authority?
- Which source systems are essential for the first use case?
- How much traceability do users need to trust a recommendation?
- What information may be processed, stored or learned from?
- How should conflicting sources and uncertainty be presented?
- What human approval is required for different decision types?
- Can a narrow workflow create more value than a broad assistant?
- What measurable outcome would prove value in a paid pilot?

## Success indicators for discovery

Proceed only if evidence demonstrates:

- a recurring, high-cost decision problem in a coherent target segment
- a clearly identified user and economic buyer
- dissatisfaction with current alternatives
- willingness to test the proposed workflow with real, permitted data
- a measurable outcome such as time saved, improved decision consistency or reduced risk
- a narrow first use case that can be tested responsibly
- acceptable security, privacy, contractual and operational constraints

## Current decision

**Proceed with conditions:** run focused discovery before selecting features or committing to implementation.

Conditions:

- validate the problem independently of the proposed solution
- identify one narrow decision workflow
- define the accountable user and buyer
- confirm data rights and source boundaries
- agree on success and failure thresholds for a pilot

## Project assets

- [Discovery plan](DISCOVERY.md)
- [Positioning and messaging](POSITIONING.md)
- [Portfolio entry](../../projects/README.md#vanthom-intelligence)
- [Product workflow](../../docs/process/WORKFLOW.md)
- [AI governance](../../docs/company/AI-GOVERNANCE.md)
- [Supplier-specific integration strategy](../../docs/strategy/integration-app-suite.md)
