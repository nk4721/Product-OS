# Product Team Workflow

## Purpose

This workflow defines how Product OS moves an initiative from idea to measurable customer value. Stages may overlap, but no required evidence or approval gate may be silently skipped.

## Stage 1: Intake

**Owner:** Product Director

Capture the idea, source, customer or business problem, strategic relevance, known constraints, and initial assumptions.

**Required output:** concise idea brief.

**Gate:** Is the idea understandable enough to investigate?

## Stage 2: Discovery

**Owner:** Discovery Agent

**Contributors:** Customer Intelligence Agent, Market Research Agent, UX Designer

Validate the problem, affected users, frequency, current alternatives, consequences, willingness to change, and available market evidence.

**Required outputs:** problem statement, customer evidence, assumptions register, competitor context, discovery recommendation.

**Gate:** Is there credible evidence of a valuable problem?

## Stage 3: Business Case and Prioritisation

**Owner:** Business Analyst & Finance Agent

**Contributors:** Growth Product Manager, Market Research Agent, Product Marketing

Define value, target segment, commercial model, cost drivers, scenarios, risks, KPIs, and the smallest testable investment.

**Required outputs:** business case, KPI proposal, recommendation to proceed, pivot, park, or stop.

**Gate:** Is the opportunity strategically and economically worth testing?

## Stage 4: Solution Definition

**Owners:** Product Director, Solution Architect, UX Designer

Define scope, user flows, architecture, integrations, data model, security, telemetry, acceptance criteria, and out-of-scope items.

**Required outputs:** product requirements, UX concept, architecture decision, delivery plan, risk assessment.

**Gate:** Is the proposed solution desirable, feasible, secure, and small enough to test?

## Stage 5: Build

**Owners:** Engineering agents

Implement in small increments with version control, tests, documentation, and observable behaviour. DevOps prepares environments and delivery pipelines. Data & AI implements telemetry and any approved analytical or AI components.

**Required outputs:** working increment, code review, automated tests, operational documentation, updated decisions.

**Gate:** Does the increment meet acceptance criteria and engineering standards?

## Stage 6: Quality and Release Readiness

**Owner:** QA Agent

Validate functional behaviour, regression, security expectations, data quality, observability, usability, documentation, and rollback readiness.

**Required outputs:** test report, unresolved defects, release recommendation, completed Definition of Done.

**Gate:** Is the value of release greater than the remaining risk?

## Stage 7: Go-to-Market and Launch

**Owners:** Product Marketing and Product Director

**Contributors:** Sales Enablement, Customer Success, Technical Writer, DevOps

Prepare positioning, target audience, pricing approval, sales material, onboarding, support readiness, release notes, communication, and launch measurement.

**Required outputs:** launch plan, approved claims, enablement package, onboarding plan, measurement dashboard.

**Gate:** Can the organization sell, deliver, support, and measure the product responsibly?

## Stage 8: Adoption and Learning

**Owners:** Growth Product Manager and Customer Success

Measure activation, adoption, retention, customer outcomes, support load, commercial results, and unexpected effects. Customer Intelligence synthesises feedback; Data & AI validates telemetry.

**Required outputs:** post-launch review, KPI results, customer learning, recommended improvements.

**Gate:** Scale, improve, reposition, maintain, or retire?

## Standard Handoff

Every handoff must contain:

- Objective and expected decision.
- Links to current source documents.
- Evidence and assumptions.
- Acceptance criteria.
- Risks, dependencies, and unresolved questions.
- Named owner and reviewer.

## Decision Outcomes

At every gate the Product Director records one of five outcomes:

- **Proceed** — evidence is sufficient for the next stage.
- **Proceed with conditions** — explicit gaps must be resolved during the next stage.
- **Pivot** — retain the opportunity but change problem, segment, value proposition, or solution.
- **Park** — valuable, but not currently prioritised.
- **Stop** — evidence does not justify further investment.

## Working Rules

- Work from the relevant product folder, not from isolated chat history.
- Keep documents concise and link to evidence rather than duplicating it.
- Update the decision log when a material choice is made.
- Never invent validation; mark assumptions clearly.
- Do not start full development before the riskiest assumptions have an agreed validation plan.
- Supplier-specific data and customer evidence must remain separated when contracts or licences require it.
- All production releases require QA and Product Director approval.
