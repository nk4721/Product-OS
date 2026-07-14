---
title: SuperOffice Data Model
vendor: SuperOffice
owner: Data & AI Agent
reviewer: Solution Architect
status: Active
version: 1.0
last_reviewed: 2026-07-14
category: Data Model
domain: SuperOffice
audience: [Solution Architect, Backend Developer, Data & AI Agent, QA Agent]
source_of_truth: [Official SuperOffice schema and tenant metadata]
related_documents: [03-API-CATALOG.md, 06-APPLICATION-MAPPING.md]
---

# Data model

Treat SuperOffice as a configurable CRM domain rather than a fixed database schema.

## Core concepts

- company and person identity
- person-to-company relations and roles
- activities with owners, dates and types
- sales with stages, amounts and probability
- projects and participants
- documents and archive metadata
- selections and membership
- lists, preferences and user-defined fields
- users, groups, roles and access context

Applications must preserve stable identifiers, tenant boundaries, ownership, timestamps and field metadata. Resolve user-defined fields through configuration rather than assuming fixed field positions.