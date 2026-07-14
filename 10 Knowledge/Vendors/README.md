---
title: Vendor Knowledge Framework
owner: Product Director
reviewer: Solution Architect
status: Active
version: 2.0
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

Vendor knowledge and product documentation remain separate:

- `10 Knowledge/Vendors/` explains vendor capabilities, constraints and integration guidance.
- Product folders explain what Product OS builds, sells and supports using that knowledge.

## Standard vendor structure

Each vendor should include a README plus platform overview, authentication, API catalog, data model, integration patterns, system mappings, error handling, security and privacy, limitations, and references.

## Rules

- Official documentation and signed agreements remain authoritative.
- Do not store credentials, secrets or personal data here.
- Verify licensing, country coverage, schemas and commercial rights before implementation.
- Separate supplier-specific products and data when contracts require it.
- Mark assumptions and unresolved questions explicitly.
- Link to official sources rather than copying large sections.