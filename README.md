# Product OS

Product OS is an operating system for an AI-assisted product organization. It connects product work, reusable knowledge, governance, specialist agents and working implementations without duplicating the same information across folders.

## Start Here

| Area | Purpose |
|---|---|
| [`projects/`](projects/README.md) | Portfolio index for current and completed initiatives |
| [`apps/`](apps/README.md) | Customer-facing products, proofs of concept and implementations |
| [`platform/`](platform/README.md) | Reusable internal technical foundations |
| [`10 Knowledge/`](10%20Knowledge/README.md) | Reusable vendor and domain knowledge |
| [`Agents/`](Agents/product-director.md) | Specialist AI role instructions |
| [`docs/`](docs/process/WORKFLOW.md) | Governance, strategy, ownership and product process |

## Current Projects

### CRM Usage Analytics

A proof of concept and business case for measuring SuperOffice CRM adoption by user and team.

- [Portfolio entry](projects/README.md#crm-usage-analytics)
- [Implementation](apps/crm-usage-analytics-poc/README.md)
- [Business case](apps/crm-usage-analytics-poc/BUSINESS-CASE.md)
- [Reusable CRM knowledge](10%20Knowledge/crm/README.md)

### Integration SDK

An internal shared foundation for supplier-specific SuperOffice applications.

- [Portfolio entry](projects/README.md#integration-sdk)
- [Platform foundation](platform/integration-sdk/README.md)
- [Integration application strategy](docs/strategy/integration-app-suite.md)
- [Vendor knowledge](10%20Knowledge/Vendors/README.md)

## Repository Model

```text
projects/       What initiatives exist and their current status
apps/           What is built for customers
platform/       What is shared internally across applications
10 Knowledge/   What the organization knows and reuses
docs/           How decisions, strategy and delivery are governed
Agents/         Who performs specialist work
```

A folder should exist only when it has a clear owner and useful content. Empty placeholders should not be created in advance.

## Governance

- [Team structure](docs/company/TEAM-STRUCTURE.md)
- [AI governance](docs/company/AI-GOVERNANCE.md)
- [Document ownership](docs/document-owners.md)
- [Workflow](docs/process/WORKFLOW.md)
- [Product playbook](docs/process/PRODUCT-PLAYBOOK.md)

## Working Principles

- Start with a customer problem and a decision to enable.
- Separate facts, evidence, assumptions and recommendations.
- Link shared knowledge rather than duplicating it inside products.
- Keep supplier-specific products, credentials, data and entitlements separated.
- Build shared platform components only when reuse is demonstrated.
- Keep project status visible in `projects/README.md`.
- Remove empty or obsolete folders instead of preserving speculative structure.
