/**
 * @cond doxygenLibsbmlInternal
 *
 * @file    L2v4CompatibilityConstraintsDeclared.cxx
 * @brief   Declarations of constraints
 * @author  SBML Team
 * 
 * <!--------------------------------------------------------------------------
 * This file is part of libSBML.  Please visit http://sbml.org for more
 * information about SBML, and the latest version of libSBML.
 *
 * Copyright (C) 2013-2014 jointly by the following organizations:
 *     1. California Institute of Technology, Pasadena, CA, USA
 *     2. EMBL European Bioinformatics Institute (EMBL-EBI), Hinxton, UK
 *     3. University of Heidelberg, Heidelberg, Germany
 *
 * Copyright (C) 2009-2013 jointly by the following organizations: 
 *     1. California Institute of Technology, Pasadena, CA, USA
 *     2. EMBL European Bioinformatics Institute (EMBL-EBI), Hinxton, UK
 *  
 * Copyright (C) 2006-2008 by the California Institute of Technology,
 *     Pasadena, CA, USA 
 *  
 * Copyright (C) 2002-2005 jointly by the following organizations:
 *     1. California Institute of Technology, Pasadena, CA, USA
 *     2. Japan Science and Technology Agency, Japan
 * 
 * This library is free software; you can redistribute it and/or modify it
 * under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation.  A copy of the license agreement is provided
 * in the file named "LICENSE.txt" included with this software distribution
 * and also available online as http://sbml.org/software/libsbml/license.html
 * ---------------------------------------------------------------------- -->*/

addConstraint(new VConstraintUnit95001(*this));

addConstraint(new VConstraintKineticLaw95002(*this));

addConstraint(new VConstraintKineticLaw95003(*this));

addConstraint(new VConstraintSpecies95004(*this));

addConstraint(new VConstraintEvent95005(*this));

addConstraint(new VConstraintModel95006(*this));

addConstraint(new DuplicateTopLevelAnnotation(95007, *this));

addConstraint(new VConstraintCompartment92009(*this));

addConstraint(new VConstraintSpeciesReference92010(*this));

addConstraint(new VConstraintModel91015(*this));

addConstraint(new VConstraintSpecies91015(*this));

addConstraint(new VConstraintReaction91016(*this));

addConstraint(new VConstraintModel91017(*this));

addConstraint(new VConstraintModel91018(*this));

addConstraint(new VConstraintEvent92011(*this));

addConstraint(new VConstraintEvent92012(*this));

addConstraint(new VConstraintEvent92013(*this));

addConstraint(new VConstraintCompartment99926(*this));

addConstraint(new VConstraintReaction91020(*this));

addConstraint(new VConstraintAssignmentRule91020(*this));

addConstraint(new VConstraintRateRule91020(*this));

addConstraint(new VConstraintAlgebraicRule91020(*this));

addConstraint(new VConstraintEventAssignment91020(*this));

addConstraint(new VConstraintTrigger91020(*this));

addConstraint(new VConstraintDelay91020(*this));

addConstraint(new VConstraintInitialAssignment91020(*this));

addConstraint(new VConstraintConstraint91020(*this));
/** @endcond */
