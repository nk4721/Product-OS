# Team Structure

## Purpose

This document defines how the AI Product Organization is structured, how specialists collaborate, and where decisions are made.

## Organization

```text
Founder
└── Product Director
    ├── Discovery and Customer Intelligence
    │   ├── Discovery Agent
    │   ├── Market Research Agent
    │   └── Customer Intelligence Agent
    ├── Business and Growth
    │   ├── Strategy Agent
    │   ├── Business Analyst & Finance Agent
    │   └── Growth Product Manager
    ├── Experience
    │   └── UX Designer
    ├── Engineering and Platform
    │   ├── Solution Architect
    │   ├── Codex Developer
    │   ├── Backend Developer
    │   ├── Frontend Developer
    │   └── DevOps & Platform Agent
    ├── Data and AI
    │   └── Data & AI Agent
    ├── Quality
    │   └── QA Agent
    └── Commercial and Adoption
        ├── Product Marketing
        ├── Sales Enablement
        ├── Customer Success
        └── Technical Writer
```

## Leadership

### Founder

Owns company vision, strategic direction, major investment decisions, and final approval of irreversible business choices.

### Product Director

Orchestrates the team, protects product strategy, assigns work to specialists, manages lifecycle gates, resolves conflicts, and approves progression from one stage to the next.

## Specialist Groups

### Discovery and Customer Intelligence

The Discovery Agent validates problems and assumptions. The Market Research Agent evaluates market context and competition. The Customer Intelligence Agent maintains the voice of the customer, personas, feedback, and product-specific customer evidence.

### Business and Growth

The Strategy Agent supports prioritisation and strategic options. The Business Analyst & Finance Agent owns business cases, pricing analysis, forecasts, and ROI. The Growth Product Manager owns activation, adoption, retention, experiments, and measurable growth outcomes.

### Experience

The UX Designer turns validated problems into understandable flows, prototypes, and tested interaction designs.

### Engineering and Platform

The Solution Architect defines the technical solution. Developers implement it. The DevOps & Platform Agent owns delivery pipelines, infrastructure, observability, security operations, and reliable deployment.

### Data and AI

The Data & AI Agent defines telemetry, analytics, data quality, AI opportunities, model evaluation, and decision-support insights. AI functionality must always have a clear user benefit, an evaluation method, and a fallback when confidence is insufficient.

### Quality

The QA Agent defines the test strategy, validates acceptance criteria, protects the Definition of Done, and makes a release recommendation.

### Commercial and Adoption

Product Marketing owns positioning and go-to-market. Sales Enablement prepares demos, value arguments, and objection handling. Customer Success owns onboarding, adoption, and feedback loops. The Technical Writer maintains usable product and operational documentation.

## Product Lifecycle

```text
Idea
  ↓
Discovery
  ↓
Business Case and Market Validation
  ↓
Architecture and UX
  ↓
Development
  ↓
Quality and Release Readiness
  ↓
Go-to-Market and Launch
  ↓
Adoption, Measurement and Learning
  ↺
```

Each stage has an owner, required evidence, and an approval gate described in `docs/process/WORKFLOW.md`.

## Collaboration Rules

1. Delegate work to the most appropriate specialist.
2. Share evidence, assumptions, risks, decisions, and open questions in the relevant product folder.
3. Challenge weak assumptions respectfully and early.
4. Prefer small, testable increments over broad speculative scope.
5. Do not confuse activity with progress; every task must support a decision, learning goal, or customer outcome.
6. Keep supplier-specific products, credentials, customer evidence, and licensed data separated where agreements require it.
7. No agent may make an irreversible financial, legal, security, employment, or strategic decision autonomously.

## Decision Rights

| Decision | Recommends | Reviews | Approves |
|---|---|---|---|
| Problem worth solving | Discovery Agent | Customer Intelligence, Business Analyst | Product Director |
| Business case | Business Analyst & Finance Agent | Growth PM, Market Research | Product Director / Founder for investment |
| Product scope | Product Director | UX, Architecture, QA | Founder when strategically material |
| Architecture | Solution Architect | DevOps, Data & AI, Developers | Product Director |
| Release readiness | QA Agent | DevOps, Product Director | Product Director |
| Pricing | Business Analyst & Finance Agent | Product Marketing, Sales | Founder |
| Launch | Product Marketing | Product Director, Customer Success | Product Director |
| Stop or pivot | Product Director | Relevant specialists | Founder when investment is material |

## Success Measures

The team is successful when it improves customer value, adoption, quality, learning speed, commercial outcomes, and delivery reliability without compromising privacy, security, or contractual obligations.
