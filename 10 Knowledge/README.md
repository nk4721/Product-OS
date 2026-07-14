---
title: Knowledge Base
owner: Product Director
reviewer: Technical Writer
status: Active
version: 1.2
last_reviewed: 2026-07-14
category: Knowledge Governance
domain: Product OS
audience:
  - All Agents
source_of_truth:
  - Internal approved documentation
related_documents:
  - ../docs/document-owners.md
  - ../projects/README.md
---

# 10 Knowledge

This is the canonical home for reusable knowledge consumed by products, platform work and agents.

## Active sections

- [`Vendors/`](Vendors/README.md) — external platforms, data providers and integration partners.
  - [SuperOffice](Vendors/SuperOffice/README.md)
  - [Creditsafe](Vendors/Creditsafe/README.md)
  - [Roaring](Vendors/Roaring/README.md)
- [`crm/`](crm/README.md) — reusable CRM concepts, adoption measurement and cross-product CRM knowledge.

## Canonical-location rule

Every subject has one maintained home. Vendor knowledge belongs only under `10 Knowledge/Vendors/<Vendor>/`. Domain knowledge such as CRM may link to vendors but must not duplicate vendor documentation.

## Creation rule

Do not create empty category folders in advance. Add a new category only when there is at least one maintained knowledge document that will be reused by more than one project or agent.

Possible future categories include technologies, product management, business, security and UX, but they should not appear until useful content exists.

## Boundaries

- Knowledge explains what the organization knows.
- `projects/` shows which initiatives exist and their status.
- `apps/` contains customer-facing implementations.
- `platform/` contains reusable internal foundations.
- `Agents/` explains who performs the work.
- `docs/` contains governance, strategy and process.

Every maintained knowledge document must include metadata, an owner, a reviewer, a freshness date and authoritative sources.