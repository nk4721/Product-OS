# Document Ownership

## Purpose

This document is the source of truth for document accountability in Product OS.

Every maintained document must have exactly one Primary Owner, at least one Reviewer for material changes, and optional Contributors. The Primary Owner keeps the document accurate, current, and aligned with related documents.

## Executive and Company

| Document | Primary Owner | Reviewer | Contributors |
|---|---|---|---|
| `docs/company/vision.md` | Product Director | Founder | Business Analyst & Finance Agent |
| `docs/company/product-strategy.md` | Product Director | Founder | Growth Product Manager, Market Research Agent |
| `roadmap.md` | Product Director | Founder | Growth Product Manager, Strategy Agent |
| `decision-log.md` | Product Director | Founder | Relevant specialist agents |
| `docs/company/shared-context.md` | Product Director | Founder | All agents |
| `docs/company/TEAM-STRUCTURE.md` | Product Director | Founder | All agent owners |
| `docs/company/AI-GOVERNANCE.md` | Product Director | Founder | DevOps & Platform Agent, Data & AI Agent |

## Discovery and Customer Intelligence

| Document | Primary Owner | Reviewer | Contributors |
|---|---|---|---|
| Discovery plan and report | Discovery Agent | Product Director | Customer Intelligence Agent |
| Problem statements | Discovery Agent | Product Director | Business Analyst & Finance Agent |
| Customer personas | Customer Intelligence Agent | Discovery Agent | UX Designer |
| Jobs to Be Done | Customer Intelligence Agent | Discovery Agent | UX Designer |
| Customer interview repository | Customer Intelligence Agent | Product Director | Discovery Agent |
| Competitor analysis | Market Research Agent | Product Director | Product Marketing |
| Ideal customer profile | Discovery Agent | Strategy Agent | Customer Intelligence Agent, Product Marketing |
| Customer feedback synthesis | Customer Intelligence Agent | Customer Success | Discovery Agent |

## Business and Product Strategy

| Document | Primary Owner | Reviewer | Contributors |
|---|---|---|---|
| Business case | Business Analyst & Finance Agent | Product Director | Market Research Agent, Growth Product Manager |
| Pricing strategy | Business Analyst & Finance Agent | Founder | Product Marketing, Sales Enablement |
| Revenue forecast | Business Analyst & Finance Agent | Founder | Growth Product Manager |
| ROI model | Business Analyst & Finance Agent | Product Director | Sales Enablement |
| OKRs | Growth Product Manager | Product Director | Founder, Data & AI Agent |
| KPI framework | Growth Product Manager | Product Director | Data & AI Agent, Customer Success |
| Product requirements | Product Director | Solution Architect | Discovery Agent, UX Designer |
| Backlog prioritisation | Product Director | Founder | Growth Product Manager, Business Analyst & Finance Agent |

## User Experience

| Document | Primary Owner | Reviewer | Contributors |
|---|---|---|---|
| User flows | UX Designer | Product Director | Discovery Agent |
| Wireframes and prototypes | UX Designer | Product Director | Frontend Developer |
| Design system | UX Designer | Frontend Developer | Product Director |
| Usability test findings | UX Designer | Discovery Agent | Customer Intelligence Agent |

## Engineering and Architecture

| Document | Primary Owner | Reviewer | Contributors |
|---|---|---|---|
| Technical architecture | Solution Architect | DevOps & Platform Agent | Backend Developer, Data & AI Agent |
| Technology stack | Solution Architect | Codex Developer | DevOps & Platform Agent |
| API specification | Backend Developer | Solution Architect | Technical Writer |
| Database design | Solution Architect | Backend Developer | Data & AI Agent |
| Integration specification | Solution Architect | Product Director | Backend Developer |
| Coding standards | Codex Developer | Solution Architect | QA Agent |

## Platform and Operations

| Document | Primary Owner | Reviewer | Contributors |
|---|---|---|---|
| CI/CD | DevOps & Platform Agent | Solution Architect | Codex Developer |
| Infrastructure | DevOps & Platform Agent | Solution Architect | Backend Developer |
| Monitoring and alerting | DevOps & Platform Agent | QA Agent | Data & AI Agent |
| Security guidelines | DevOps & Platform Agent | Founder | Solution Architect |
| Backup and recovery | DevOps & Platform Agent | Product Director | Solution Architect |
| Deployment runbook | DevOps & Platform Agent | QA Agent | Technical Writer |

## Data, AI and Analytics

| Document | Primary Owner | Reviewer | Contributors |
|---|---|---|---|
| Analytics strategy | Data & AI Agent | Growth Product Manager | Product Director |
| Product telemetry | Data & AI Agent | DevOps & Platform Agent | Backend Developer |
| AI feature specification | Data & AI Agent | Product Director | Solution Architect |
| Dashboard definitions | Data & AI Agent | Growth Product Manager | Customer Success |
| Adoption metrics | Growth Product Manager | Data & AI Agent | Customer Success |
| Data quality rules | Data & AI Agent | Solution Architect | QA Agent |

## Quality and Release

| Document | Primary Owner | Reviewer | Contributors |
|---|---|---|---|
| Test strategy | QA Agent | Product Director | Engineering agents |
| Test cases | QA Agent | Solution Architect | Codex Developer |
| Definition of Done | QA Agent | Product Director | Engineering agents |
| Release checklist | QA Agent | DevOps & Platform Agent | Customer Success |
| Release plan | Product Director | QA Agent | DevOps, Product Marketing, Customer Success |

## Commercial and Customer Success

| Document | Primary Owner | Reviewer | Contributors |
|---|---|---|---|
| Brand voice | Product Marketing | Product Director | Founder |
| Go-to-market plan | Product Marketing | Product Director | Sales Enablement, Growth Product Manager |
| Messaging and positioning | Product Marketing | Founder | Customer Intelligence Agent |
| Sales playbook | Sales Enablement | Product Marketing | Customer Success |
| Demo script | Sales Enablement | Product Director | Solution Architect |
| Onboarding plan | Customer Success | Product Director | Technical Writer |
| User documentation | Technical Writer | Customer Success | Engineering agents |
| Release notes | Technical Writer | Product Director | QA Agent, Product Marketing |

## Process and Governance

| Document | Primary Owner | Reviewer | Contributors |
|---|---|---|---|
| `docs/process/product-process.md` | Product Director | Founder | All agents |
| `docs/process/WORKFLOW.md` | Product Director | QA Agent | All agents |
| `docs/process/PRODUCT-PLAYBOOK.md` | Product Director | Founder | All specialist leads |
| Documentation standards | Technical Writer | Product Director | All agents |

## Vendor Knowledge

| Document | Primary Owner | Reviewer | Contributors |
|---|---|---|---|
| `04 Vendors/README.md` | Product Director | Solution Architect | Technical Writer, all vendor knowledge owners |
| `04 Vendors/_templates/VENDOR-DOCUMENT-TEMPLATE.md` | Technical Writer | Product Director | Solution Architect |
| Vendor platform overview | Product Director | Solution Architect | Discovery Agent, Product Marketing |
| Vendor authentication | Solution Architect | DevOps & Platform Agent | Backend Developer, QA Agent |
| Vendor API capability catalog | Solution Architect | Product Director | Backend Developer, Product Marketing |
| Vendor normalized data model | Data & AI Agent | Solution Architect | Backend Developer, QA Agent |
| Vendor integration patterns | Solution Architect | Backend Developer | DevOps & Platform Agent, QA Agent |
| Vendor-to-SuperOffice mapping | Solution Architect | Product Director | Backend Developer, Customer Success, QA Agent |
| Vendor error handling | Backend Developer | QA Agent | Solution Architect, DevOps & Platform Agent |
| Vendor security and privacy | DevOps & Platform Agent | Product Director | Solution Architect, Data & AI Agent |
| Vendor limitations register | Product Director | Solution Architect | Discovery Agent, QA Agent, Product Marketing |
| Vendor references and review register | Technical Writer | Solution Architect | Product Director |

Vendor knowledge owners are responsible for internal interpretation and freshness. Official vendor documentation, signed agreements and customer entitlements remain authoritative for API details and permitted use.

## Ownership Rules

1. Every document has exactly one Primary Owner.
2. The Primary Owner may delegate work but remains accountable for quality and freshness.
3. Material strategic, financial, security, legal, architectural, vendor, or release changes require Reviewer approval.
4. Contributors provide specialist input but do not make the final decision.
5. The Product Director resolves ownership conflicts and reviews cross-functional documents.
6. The Founder approves changes to company vision, strategy, major investment, pricing authority, and governance.
7. Product-specific customer and supplier data must remain separated when contracts, licences, or privacy requirements demand it.
8. Vendor knowledge must distinguish verified facts, internal interpretations, assumptions and open questions.
9. Retired documents must be marked as archived and replaced with a link to the current source of truth.

## Review Cadence

- Strategic and governance documents: quarterly or after a major decision.
- Product documents: at each lifecycle gate.
- Operational documents: after every material platform or release change.
- Vendor knowledge: quarterly and whenever documentation, APIs, authentication, commercial rights, coverage or contracts change.
- Customer and market documents: whenever new evidence changes an assumption.