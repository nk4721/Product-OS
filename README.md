# Product OS

Product OS is an operating system for an AI-assisted product organization. It combines specialist agent instructions, governance, product processes, reusable documentation, and working product experiments in one repository.

## How the Organization Works

The Founder sets vision and approves major strategic, financial, legal, and irreversible decisions. The Product Director coordinates specialist agents and manages the product lifecycle from idea through discovery, delivery, launch, adoption, and learning.

```text
Founder
└── Product Director
    ├── Discovery and Customer Intelligence
    ├── Business and Growth
    ├── UX
    ├── Engineering and Platform
    ├── Data and AI
    ├── Quality
    └── Commercial and Customer Success
```

## Start Here

| Document | Purpose |
|---|---|
| [`docs/company/TEAM-STRUCTURE.md`](docs/company/TEAM-STRUCTURE.md) | Roles, organization, collaboration, and decision rights |
| [`docs/company/AI-GOVERNANCE.md`](docs/company/AI-GOVERNANCE.md) | Authority, safety, data governance, and human oversight |
| [`docs/document-owners.md`](docs/document-owners.md) | Primary owners, reviewers, contributors, and review cadence |
| [`docs/process/WORKFLOW.md`](docs/process/WORKFLOW.md) | Lifecycle stages, required evidence, handoffs, and gates |
| [`docs/process/PRODUCT-PLAYBOOK.md`](docs/process/PRODUCT-PLAYBOOK.md) | Practical standards for discovery, business cases, delivery, release, and learning |
| [`Agents/product-director.md`](Agents/product-director.md) | Operating instructions for the Product Director |

## Repository Structure

```text
Agents/      Specialist AI role instructions
docs/        Company context, governance, product process, and standards
apps/        Proofs of concept and product implementations
```

## Product Lifecycle

```text
Idea
→ Discovery
→ Business Case and Market Validation
→ Solution Definition
→ Build
→ Quality and Release Readiness
→ Go-to-Market and Launch
→ Adoption, Measurement, and Learning
```

Each stage should have a named owner, documented evidence, explicit assumptions, measurable success criteria, and a recorded decision to proceed, proceed with conditions, pivot, park, or stop.

## Working Principles

- Start with a customer problem and a decision to enable.
- Separate facts, evidence, assumptions, and recommendations.
- Delegate specialist work to the appropriate agent.
- Build the smallest responsible increment that creates value or learning.
- Keep decisions traceable and documentation owned.
- Protect privacy, security, contracts, licences, and customer confidentiality.
- Keep supplier-specific products, credentials, data, and evidence separated when required.
- Require human approval for material or irreversible decisions.
- Improve Product OS after every completed initiative.

## Current Product Work

The repository includes a CRM Usage Analytics proof of concept for measuring SuperOffice CRM adoption by user and team, together with its technical implementation and business case under `apps/crm-usage-analytics-poc/`.
