# Repository Architecture

## Purpose

This document is the canonical contract for the top-level structure of Product OS. It replaces earlier speculative folder models and describes the folders that are actively used in the repository.

## Canonical top-level folders

```text
Product-OS/
├── projects/
├── apps/
├── platform/
├── 10 Knowledge/
├── docs/
├── Agents/
└── README.md
```

## Folder responsibilities

### `projects/` — portfolio and status

Answers: **Which initiatives exist, and what is their current status?**

Contains a lightweight portfolio index. It links to implementation, strategy, business cases and knowledge without duplicating them.

Current initiatives:

- CRM Usage Analytics
- Integration SDK

A project entry must include type, status, purpose, key assets, dependencies and current decision.

### `apps/` — customer-facing implementations

Answers: **What are we building for customers or testing as a product?**

Contains products, proofs of concept and independently deployable supplier-specific applications.

Each application should normally contain:

- `README.md` or `PROJECT.md`
- product scope and run instructions
- product-specific architecture and configuration
- source code and tests
- business case, backlog and release information when applicable

Product-specific supplier clients, credentials, contracts and business rules stay inside the relevant application boundary.

### `platform/` — reusable internal foundations

Answers: **What internal capability is shared across applications?**

Contains technical foundations that are not commercial products and are not tied to one supplier.

Current platform work:

- Integration SDK

A platform component should be created only when reuse is demonstrated or when it represents fundamental shared infrastructure.

### `10 Knowledge/` — reusable reference knowledge

Answers: **What does the organization know that several projects or agents can reuse?**

Contains curated vendor and domain knowledge. It must not duplicate product requirements or implementation code.

Current active sections:

- `Vendors/`
  - SuperOffice
  - Creditsafe
  - Roaring
- `crm/`

There must be one canonical knowledge location per subject. Empty knowledge categories must not be created in advance.

### `docs/` — governance, strategy and process

Answers: **How does Product OS make decisions and operate?**

Contains:

- company and team governance
- AI governance
- product workflow and playbook
- portfolio and integration strategy
- ownership and review rules
- repository architecture and audit records

Documents that apply only to one product should normally remain in that product folder.

### `Agents/` — specialist role instructions

Answers: **Who performs the work, and how should that role behave?**

Contains the operating instructions for Product Director, Discovery, Architecture, Development, QA, Marketing, Customer Success and other specialist agents.

Agent files should reference shared knowledge and process documents rather than copying them.

### `README.md` — repository front door

Answers: **Where should a person or agent start?**

The root README must link to the portfolio, implementations, platform, knowledge, governance and agents. It should not attempt to store detailed content from those areas.

## Placement decision tree

1. Is it the status or overview of an initiative? Put it in `projects/`.
2. Is it customer-facing code or product-specific documentation? Put it in `apps/`.
3. Is it shared internal infrastructure? Put it in `platform/`.
4. Is it reusable vendor or domain reference knowledge? Put it in `10 Knowledge/`.
5. Is it organization-wide governance, strategy or process? Put it in `docs/`.
6. Is it an AI role instruction? Put it in `Agents/`.

## Anti-duplication rules

- One project has one portfolio entry.
- One vendor has one canonical knowledge folder.
- Shared knowledge is linked, not copied into applications.
- Product-specific decisions stay with the product.
- Empty speculative folders are removed.
- A new top-level folder requires a distinct responsibility that cannot fit the existing model.

## Lifecycle connection

```text
Idea or opportunity
       ↓
projects/ portfolio entry
       ↓
Discovery and governance in docs/
       ↓
Implementation in apps/ or platform/
       ↓
Reusable learning promoted to 10 Knowledge/
       ↓
Agents use the shared process and knowledge for the next initiative
```

## Ownership

The Product Director owns this architecture. The Technical Writer reviews navigation and clarity. The Solution Architect reviews the boundary between `apps/`, `platform/` and technical knowledge.