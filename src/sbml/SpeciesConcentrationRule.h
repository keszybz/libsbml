/**
 * Filename    : SpeciesConcentrationRule.h
 * Description : SBML SpeciesConcentrationRule
 * Author(s)   : SBW Development Group <sysbio-team@caltech.edu>
 * Organization: Caltech ERATO Kitano Systems Biology Project
 * Created     : 2002-11-26
 * Revision    : $Id$
 * Source      : $Source$
 *
 * Copyright 2002 California Institute of Technology and
 * Japan Science and Technology Corporation.
 *
 * This library is free software; you can redistribute it and/or modify it
 * under the terms of the GNU Lesser General Public License as published
 * by the Free Software Foundation; either version 2.1 of the License, or
 * any later version.
 *
 * This library is distributed in the hope that it will be useful, but
 * WITHOUT ANY WARRANTY, WITHOUT EVEN THE IMPLIED WARRANTY OF
 * MERCHANTABILITY OR FITNESS FOR A PARTICULAR PURPOSE.  The software and
 * documentation provided hereunder is on an "as is" basis, and the
 * California Institute of Technology and Japan Science and Technology
 * Corporation have no obligations to provide maintenance, support,
 * updates, enhancements or modifications.  In no event shall the
 * California Institute of Technology or the Japan Science and Technology
 * Corporation be liable to any party for direct, indirect, special,
 * incidental or consequential damages, including lost profits, arising
 * out of the use of this software and its documentation, even if the
 * California Institute of Technology and/or Japan Science and Technology
 * Corporation have been advised of the possibility of such damage.  See
 * the GNU Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with this library; if not, write to the Free Software Foundation,
 * Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA.
 *
 * The original code contained here was initially developed by:
 *
 *     Ben Bornstein
 *     The Systems Biology Workbench Development Group
 *     ERATO Kitano Systems Biology Project
 *     Control and Dynamical Systems, MC 107-81
 *     California Institute of Technology
 *     Pasadena, CA, 91125, USA
 *
 *     http://www.cds.caltech.edu/erato
 *     mailto:sysbio-team@caltech.edu
 *
 * Contributor(s):
 */


#ifndef SpeciesConcentrationRule_h
#define SpeciesConcentrationRule_h


#include "common.h"
#include "SBase.h"
#include "Rule.h"
#include "AssignmentRule.h"


BEGIN_C_DECLS


typedef struct
{
  SBASE_FIELDS;
  RULE_FIELDS;
  ASSIGNMENT_RULE_FIELDS;
  char *species;
} SpeciesConcentrationRule_t;


/**
 * Creates a new SpeciesConcentrationRule and returns a pointer to it.
 */
LIBSBML_EXTERN
SpeciesConcentrationRule_t *
SpeciesConcentrationRule_create (void);

/**
 * Creates a new SpeciesConcentrationRule with the given formula, type and
 * species and returns a pointer to it.  This convenience function is
 * functionally equivalent to:
 *
 *   SpeciesConcentrationRule_t *scr = SpeciesConcentrationRule_create();
 *   Rule_setFormula((Rule_t *) scr, formula); scr->type = type; ...;
 */
LIBSBML_EXTERN
SpeciesConcentrationRule_t *
SpeciesConcentrationRule_createWith ( const char *formula,
                                      RuleType_t type,
                                      const char *species );

/**
 * Frees the given SpeciesConcentrationRule.
 */
LIBSBML_EXTERN
void
SpeciesConcentrationRule_free (SpeciesConcentrationRule_t *scr);


/**
 * @return the species of this SpeciesConcentrationRule.
 */
LIBSBML_EXTERN
const char *
SpeciesConcentrationRule_getSpecies (const SpeciesConcentrationRule_t *scr);

/**
 * @return 1 if the species of this SpeciesConcentrationRule has been set,
 * 0 otherwise.
 */
LIBSBML_EXTERN
int
SpeciesConcentrationRule_isSetSpecies (const SpeciesConcentrationRule_t *scr);

/**
 * Sets the species of this SpeciesConcentrationRule to a copy of sname.
 */
LIBSBML_EXTERN
void
SpeciesConcentrationRule_setSpecies ( SpeciesConcentrationRule_t *scr,
                                      const char *sname );


END_C_DECLS


#endif  /** SpeciesConcentrationRule_h **/
