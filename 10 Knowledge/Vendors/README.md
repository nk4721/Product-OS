---
title: Vendor Knowledge Framework
owner: Product Director
reviewer: Solution Architect
status: Active
version: 2.1
last_reviewed: 2026-07-14
category: Knowledge Governance
domain: Vendors
audience:
  - All Agents
source_of_truth:
  - Official vendor documentation
related_documents:
  - ../README.md
  - ../../docs/document-owners.md
  - ../../docs/company/AI-GOVERNANCE.md
---

# Vendor Knowledge

This folder contains reusable internal knowledge about external platforms, data providers and integration partners.

## Canonical vendor folders

There is exactly one maintained knowledge base per vendor:

| Vendor | Canonical location | Primary use |
|---|---|---|
| [SuperOffice](SuperOffice/README.md) | `10 Knowledge/Vendors/SuperOffice/` | Shared CRM platform and integration knowledge |
| [Creditsafe](Creditsafe/README.md) | `10 Knowledge/Vendors/Creditsafe/` | Company, credit and monitoring knowledge for Creditsafe products |
| [Roaring](Roaring/README.md) | `10 Knowledge/Vendors/Roaring/` | Company, person and compliance-related integration knowledge |

Any link elsewhere in the repository must point to one of these canonical folders. A vendor must not have a second knowledge folder under another path.

## Knowledge and product boundary

- `10 Knowledge/Vendors/` explains vendor capabilities, constraints and reusable integration guidance.
- `apps/` explains what Product OS builds, sells and supports using that knowledge.
- `platform/` contains reusable internal infrastructure that is not supplier-specific.

## Standard vendor structure

Each vendor includes a README plus platform overview, authentication, API catalog, data model, integration patterns, mappings, error handling, security and privacy, limitations, and references.

## Rules

- Official documentation and signed agreements remain authoritative.
- Do not store credentials, secrets or personal data here.
- Verify licensing, country coverage, schemas and commercial rights before implementation.
- Separate supplier-specific products and data when contracts require it.
- Mark assumptions and unresolved questions explicitly.
- Link to official sources rather than copying large sections.
- Create a new vendor folder only when maintained knowledge or an active product requires it.