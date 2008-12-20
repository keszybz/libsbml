/// 
///  @file    TestASTNode.cs
///  @brief   ASTNode unit tests
///  @author  Frank Bergmann (Csharp conversion)
///  @author  Akiya Jouraku (Csharp conversion)
///  @author  Ben Bornstein 
/// 
///  $Id:$
///  $HeadURL:$
/// 
///  This test file was converted from src/sbml/test/TestASTNode.c
///  with the help of conversion sciprt (ctest_converter.pl).
/// 
/// <!---------------------------------------------------------------------------
///  This file is part of libSBML.  Please visit http://sbml.org for more
///  information about SBML, and the latest version of libSBML.
/// 
///  Copyright 2005-2008 California Institute of Technology.
///  Copyright 2002-2005 California Institute of Technology and
///                      Japan Science and Technology Corporation.
///  
///  This library is free software; you can redistribute it and/or modify it
///  under the terms of the GNU Lesser General Public License as published by
///  the Free Software Foundation.  A copy of the license agreement is provided
///  in the file named "LICENSE.txt" included with this software distribution
///  and also available online as http://sbml.org/software/libsbml/license.html
/// --------------------------------------------------------------------------->*/


namespace LibSBMLCSTest {

  using libsbml;

  using  System.IO;


  public class TestASTNode {

    private const double DBL_EPSILON =  2.2204460492503131e-016;

    public class AssertionError : System.Exception 
    {
      public AssertionError() : base()
      {
        
      }
    }


    static void assertTrue(bool condition)
    {
      if (condition == true)
      {
        return;
      }
      throw new AssertionError();
    }

    static void assertEquals(object a, object b)
    {
      if ( (a == null) && (b == null) )
      {
        return;
      }
      else if (a.Equals(b))
      {
        return;
      }
  
      throw new AssertionError();
    }

    static void assertNotEquals(object a, object b)
    {
      if ( (a == null) && (b == null) )
      {
        throw new AssertionError();
      }
      else if (a.Equals(b))
      {
        throw new AssertionError();
      }
    }

    static void assertEquals(bool a, bool b)
    {
      if ( a == b )
      {
        return;
      }
      throw new AssertionError();
    }

    static void assertNotEquals(bool a, bool b)
    {
      if ( a != b )
      {
        return;
      }
      throw new AssertionError();
    }

    static void assertEquals(int a, int b)
    {
      if ( a == b )
      {
        return;
      }
      throw new AssertionError();
    }

    static void assertNotEquals(int a, int b)
    {
      if ( a != b )
      {
        return;
      }
      throw new AssertionError();
    }


    public void test_ASTNode_canonicalizeConstants()
    {
      ASTNode n = new  ASTNode();
      n.setName( "ExponentialE");
      assertEquals( true, n.isName() );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_CONSTANT_E );
      n.setType(libsbml.AST_NAME);
      n.setName( "False");
      assertEquals( true, n.isName() );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_CONSTANT_FALSE );
      n.setType(libsbml.AST_NAME);
      n.setName( "Pi");
      assertEquals( true, n.isName() );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_CONSTANT_PI );
      n.setType(libsbml.AST_NAME);
      n.setName( "True");
      assertEquals( true, n.isName() );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_CONSTANT_TRUE );
      n.setType(libsbml.AST_NAME);
      n.setName( "Foo");
      assertEquals( true, n.isName() );
      n.canonicalize();
      assertEquals( true, n.isName() );
      n = null;
    }

    public void test_ASTNode_canonicalizeFunctions()
    {
      ASTNode n = new  ASTNode(libsbml.AST_FUNCTION);
      n.setName( "abs");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_ABS );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "arccos");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_ARCCOS );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "arccosh");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_ARCCOSH );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "arccot");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_ARCCOT );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "arccoth");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_ARCCOTH );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "arccsc");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_ARCCSC );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "arccsch");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_ARCCSCH );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "arcsec");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_ARCSEC );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "arcsech");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_ARCSECH );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "arcsin");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_ARCSIN );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "arcsinh");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_ARCSINH );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "arctan");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_ARCTAN );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "arctanh");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_ARCTANH );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "ceiling");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_CEILING );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "cos");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_COS );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "cosh");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_COSH );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "cot");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_COT );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "coth");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_COTH );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "csc");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_CSC );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "csch");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_CSCH );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "exp");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_EXP );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "factorial");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_FACTORIAL );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "floor");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_FLOOR );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "lambda");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_LAMBDA );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "ln");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_LN );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "log");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_LOG );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "piecewise");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_PIECEWISE );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "power");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_POWER );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "root");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_ROOT );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "sec");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_SEC );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "sech");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_SECH );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "sin");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_SIN );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "sinh");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_SINH );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "tan");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_TAN );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "tanh");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_TANH );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "Foo");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n = null;
    }

    public void test_ASTNode_canonicalizeFunctionsL1()
    {
      ASTNode n = new  ASTNode(libsbml.AST_FUNCTION);
      ASTNode c;
      n.setName( "acos");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_ARCCOS );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "asin");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_ARCSIN );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "atan");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_ARCTAN );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "ceil");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_CEILING );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "pow");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_POWER );
      n = null;
      n = new  ASTNode(libsbml.AST_FUNCTION);
      n.setName( "log");
      c = new  ASTNode();
      c.setName( "x");
      n.addChild(c);
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      assertTrue( n.getNumChildren() == 1 );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_LN );
      assertTrue( n.getNumChildren() == 1 );
      n.setType(libsbml.AST_FUNCTION);
      c = new  ASTNode();
      c.setName( "y");
      n.addChild(c);
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      assertTrue( n.getNumChildren() == 2 );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_LOG );
      n = null;
      n = new  ASTNode(libsbml.AST_FUNCTION);
      n.setName( "log10");
      c = new  ASTNode();
      c.setName( "x");
      n.addChild(c);
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      assertTrue( n.getNumChildren() == 1 );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_LOG );
      assertTrue( n.getNumChildren() == 2 );
      c = n.getLeftChild();
      assertTrue( c.getType() == libsbml.AST_INTEGER );
      assertTrue( c.getInteger() == 10 );
      c = n.getRightChild();
      assertTrue( c.getType() == libsbml.AST_NAME );
      assertTrue((  "x" == c.getName() ));
      n = null;
      n = new  ASTNode(libsbml.AST_FUNCTION);
      n.setName( "sqr");
      c = new  ASTNode();
      c.setName( "x");
      n.addChild(c);
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      assertTrue( n.getNumChildren() == 1 );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_POWER );
      assertTrue( n.getNumChildren() == 2 );
      c = n.getLeftChild();
      assertTrue( c.getType() == libsbml.AST_NAME );
      assertTrue((  "x" == c.getName() ));
      c = n.getRightChild();
      assertTrue( c.getType() == libsbml.AST_INTEGER );
      assertTrue( c.getInteger() == 2 );
      n = null;
      n = new  ASTNode(libsbml.AST_FUNCTION);
      n.setName( "sqrt");
      c = new  ASTNode();
      c.setName( "x");
      n.addChild(c);
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      assertTrue( n.getNumChildren() == 1 );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_FUNCTION_ROOT );
      assertTrue( n.getNumChildren() == 2 );
      c = n.getLeftChild();
      assertTrue( c.getType() == libsbml.AST_INTEGER );
      assertTrue( c.getInteger() == 2 );
      c = n.getRightChild();
      assertTrue( c.getType() == libsbml.AST_NAME );
      assertTrue((  "x" == c.getName() ));
      n = null;
    }

    public void test_ASTNode_canonicalizeLogical()
    {
      ASTNode n = new  ASTNode(libsbml.AST_FUNCTION);
      n.setName( "and");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_LOGICAL_AND );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "not");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_LOGICAL_NOT );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "or");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_LOGICAL_OR );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "xor");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_LOGICAL_XOR );
      n.setType(libsbml.AST_FUNCTION);
      n = null;
    }

    public void test_ASTNode_canonicalizeRelational()
    {
      ASTNode n = new  ASTNode(libsbml.AST_FUNCTION);
      n.setName( "eq");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_RELATIONAL_EQ );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "geq");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_RELATIONAL_GEQ );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "gt");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_RELATIONAL_GT );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "leq");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_RELATIONAL_LEQ );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "lt");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_RELATIONAL_LT );
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "neq");
      assertTrue( n.getType() == libsbml.AST_FUNCTION );
      n.canonicalize();
      assertTrue( n.getType() == libsbml.AST_RELATIONAL_NEQ );
      n.setType(libsbml.AST_FUNCTION);
      n = null;
    }

    public void test_ASTNode_children()
    {
      ASTNode parent = new  ASTNode();
      ASTNode left = new  ASTNode();
      ASTNode right = new  ASTNode();
      ASTNode right2 = new  ASTNode();
      parent.setType(libsbml.AST_PLUS);
      left.setValue(1);
      right.setValue(2);
      right2.setValue(3);
      parent.addChild(left);
      parent.addChild(right);
      assertTrue( parent.getNumChildren() == 2 );
      assertTrue( left.getNumChildren() == 0 );
      assertTrue( right.getNumChildren() == 0 );
      assertTrue( parent.getLeftChild() == left );
      assertTrue( parent.getRightChild() == right );
      assertTrue( parent.getChild(0) == left );
      assertTrue( parent.getChild(1) == right );
      assertTrue( parent.getChild(2) == null );
      parent.addChild(right2);
      assertTrue( parent.getNumChildren() == 3 );
      assertTrue( left.getNumChildren() == 0 );
      assertTrue( right.getNumChildren() == 0 );
      assertTrue( right2.getNumChildren() == 0 );
      assertTrue( parent.getLeftChild() == left );
      assertTrue( parent.getRightChild() == right2 );
      assertTrue( parent.getChild(0) == left );
      assertTrue( parent.getChild(1) == right );
      assertTrue( parent.getChild(2) == right2 );
      assertTrue( parent.getChild(3) == null );
      parent = null;
    }

    public void test_ASTNode_create()
    {
      ASTNode n = new  ASTNode();
      EventAssignment ea = new  EventAssignment();
      assertTrue( n.getType() == libsbml.AST_UNKNOWN );
      assertTrue( n.getCharacter() ==  '\0'  );
      assertTrue( n.getName() == null );
      assertTrue( n.getInteger() == 0 );
      assertTrue( n.getExponent() == 0 );
      assertTrue( n.getNumChildren() == 0 );
      assertTrue( n.getParentSBMLObject() == null );
      ea = null;
      n = null;
    }

    public void test_ASTNode_deepCopy_1()
    {
      ASTNode node = new  ASTNode();
      ASTNode child,copy;
      node.setCharacter( '+');
      node.addChild(new  ASTNode());
      node.addChild(new  ASTNode());
      node.getLeftChild().setValue(1);
      node.getRightChild().setValue(2);
      assertTrue( node.getType() == libsbml.AST_PLUS );
      assertTrue( node.getCharacter() ==  '+'       );
      assertTrue( node.getNumChildren() == 2 );
      child = node.getLeftChild();
      assertTrue( child.getType() == libsbml.AST_INTEGER );
      assertTrue( child.getInteger() == 1 );
      assertTrue( child.getNumChildren() == 0 );
      child = node.getRightChild();
      assertTrue( child.getType() == libsbml.AST_INTEGER );
      assertTrue( child.getInteger() == 2 );
      assertTrue( child.getNumChildren() == 0 );
      copy = node.deepCopy();
      assertTrue( copy != node );
      assertTrue( copy.getType() == libsbml.AST_PLUS );
      assertTrue( copy.getCharacter() ==  '+'       );
      assertTrue( copy.getNumChildren() == 2 );
      child = copy.getLeftChild();
      assertTrue( child != node.getLeftChild() );
      assertTrue( child.getType() == libsbml.AST_INTEGER );
      assertTrue( child.getInteger() == 1 );
      assertTrue( child.getNumChildren() == 0 );
      child = copy.getRightChild();
      assertTrue( child != node.getRightChild() );
      assertTrue( child.getType() == libsbml.AST_INTEGER );
      assertTrue( child.getInteger() == 2 );
      assertTrue( child.getNumChildren() == 0 );
      node = null;
      copy = null;
    }

    public void test_ASTNode_deepCopy_2()
    {
      ASTNode node = new  ASTNode();
      ASTNode copy;
      node.setName( "Foo");
      assertTrue( node.getType() == libsbml.AST_NAME );
      assertTrue((  "Foo" == node.getName() ));
      assertTrue( node.getNumChildren() == 0 );
      copy = node.deepCopy();
      assertTrue( copy != node );
      assertTrue( copy.getType() == libsbml.AST_NAME );
      assertTrue((  "Foo" == copy.getName() ));
      assertTrue( copy.getNumChildren() == 0 );
      node = null;
      copy = null;
    }

    public void test_ASTNode_deepCopy_3()
    {
      ASTNode node = new  ASTNode(libsbml.AST_FUNCTION);
      ASTNode copy;
      node.setName( "Foo");
      assertTrue( node.getType() == libsbml.AST_FUNCTION );
      assertTrue((  "Foo" == node.getName() ));
      assertTrue( node.getNumChildren() == 0 );
      copy = node.deepCopy();
      assertTrue( copy != node );
      assertTrue( copy.getType() == libsbml.AST_FUNCTION );
      assertTrue((  "Foo" == copy.getName() ));
      assertTrue( copy.getNumChildren() == 0 );
      node = null;
      copy = null;
    }

    public void test_ASTNode_deepCopy_4()
    {
      ASTNode node = new  ASTNode(libsbml.AST_FUNCTION_ABS);
      ASTNode copy;
      node.setName( "ABS");
      assertTrue( node.getType() == libsbml.AST_FUNCTION_ABS );
      assertTrue((  "ABS" == node.getName() ));
      assertTrue( node.getNumChildren() == 0 );
      copy = node.deepCopy();
      assertTrue( copy != node );
      assertTrue( copy.getType() == libsbml.AST_FUNCTION_ABS );
      assertTrue((  "ABS" == copy.getName() ));
      assertTrue( copy.getNumChildren() == 0 );
      node = null;
      copy = null;
    }

    public void test_ASTNode_free_NULL()
    {
    }

    public void test_ASTNode_getName()
    {
      ASTNode n = new  ASTNode();
      n.setName( "foo");
      assertTrue((  "foo" == n.getName() ));
      n.setType(libsbml.AST_NAME_TIME);
      assertTrue((  "foo" == n.getName() ));
      n.setName(null);
      assertTrue( n.getName() == null );
      n.setType(libsbml.AST_CONSTANT_E);
      assertTrue((  "exponentiale" == n.getName() ));
      n.setType(libsbml.AST_CONSTANT_FALSE);
      assertTrue((  "false" == n.getName() ));
      n.setType(libsbml.AST_CONSTANT_PI);
      assertTrue((  "pi" == n.getName() ));
      n.setType(libsbml.AST_CONSTANT_TRUE);
      assertTrue((  "true" == n.getName() ));
      n.setType(libsbml.AST_LAMBDA);
      assertTrue((  "lambda" == n.getName() ));
      n.setType(libsbml.AST_FUNCTION);
      n.setName( "f");
      assertTrue((  "f" == n.getName() ));
      n.setType(libsbml.AST_FUNCTION_DELAY);
      assertTrue((  "f" == n.getName() ));
      n.setName(null);
      assertTrue((  "delay" == n.getName() ));
      n.setType(libsbml.AST_FUNCTION);
      assertTrue( n.getName() == null );
      n.setType(libsbml.AST_FUNCTION_ABS);
      assertTrue((  "abs" == n.getName() ));
      n.setType(libsbml.AST_FUNCTION_ARCCOS);
      assertTrue((  "arccos" == n.getName() ));
      n.setType(libsbml.AST_FUNCTION_TAN);
      assertTrue((  "tan" == n.getName() ));
      n.setType(libsbml.AST_FUNCTION_TANH);
      assertTrue((  "tanh" == n.getName() ));
      n.setType(libsbml.AST_LOGICAL_AND);
      assertTrue((  "and" == n.getName() ));
      n.setType(libsbml.AST_LOGICAL_NOT);
      assertTrue((  "not" == n.getName() ));
      n.setType(libsbml.AST_LOGICAL_OR);
      assertTrue((  "or" == n.getName() ));
      n.setType(libsbml.AST_LOGICAL_XOR);
      assertTrue((  "xor" == n.getName() ));
      n.setType(libsbml.AST_RELATIONAL_EQ);
      assertTrue((  "eq" == n.getName() ));
      n.setType(libsbml.AST_RELATIONAL_GEQ);
      assertTrue((  "geq" == n.getName() ));
      n.setType(libsbml.AST_RELATIONAL_LT);
      assertTrue((  "lt" == n.getName() ));
      n.setType(libsbml.AST_RELATIONAL_NEQ);
      assertTrue((  "neq" == n.getName() ));
      n = null;
    }

    public void test_ASTNode_getPrecedence()
    {
      ASTNode n = new  ASTNode();
      n.setType(libsbml.AST_PLUS);
      assertTrue( n.getPrecedence() == 2 );
      n.setType(libsbml.AST_MINUS);
      assertTrue( n.getPrecedence() == 2 );
      n.setType(libsbml.AST_TIMES);
      assertTrue( n.getPrecedence() == 3 );
      n.setType(libsbml.AST_DIVIDE);
      assertTrue( n.getPrecedence() == 3 );
      n.setType(libsbml.AST_POWER);
      assertTrue( n.getPrecedence() == 4 );
      n.setType(libsbml.AST_MINUS);
      n.addChild(new  ASTNode(libsbml.AST_NAME));
      assertTrue( n.isUMinus() == true );
      assertTrue( n.getPrecedence() == 5 );
      n.setType(libsbml.AST_NAME);
      assertTrue( n.getPrecedence() == 6 );
      n.setType(libsbml.AST_FUNCTION);
      assertTrue( n.getPrecedence() == 6 );
      n = null;
    }

    public void test_ASTNode_getReal()
    {
      ASTNode n = new  ASTNode();
      n.setType(libsbml.AST_REAL);
      n.setValue(1.6);
      assertTrue( n.getReal() == 1.6 );
      n.setType(libsbml.AST_REAL_E);
      n.setValue(12.3,3);
      assertTrue( System.Math.Abs(n.getReal() - 12300.0) < DBL_EPSILON );
      n.setType(libsbml.AST_RATIONAL);
      n.setValue(1,2);
      assertTrue( n.getReal() == 0.5 );
      n = null;
    }

    public void test_ASTNode_insertChild()
    {
      ASTNode node = new  ASTNode();
      ASTNode c1 = new  ASTNode();
      ASTNode c2 = new  ASTNode();
      ASTNode c3 = new  ASTNode();
      ASTNode newc = new  ASTNode();
      ASTNode newc1 = new  ASTNode();
      long i = 0;
      node.setType(libsbml.AST_LOGICAL_AND);
      c1.setName( "a");
      c2.setName( "b");
      c3.setName( "c");
      node.addChild(c1);
      node.addChild(c2);
      node.addChild(c3);
      assertTrue( node.getNumChildren() == 3 );
      assertTrue((  "and(a, b, c)" == libsbml.formulaToString(node) ));
      newc.setName( "d");
      newc1.setName( "e");
      i = node.insertChild(1,newc);
      assertTrue( i == 0 );
      assertTrue( node.getNumChildren() == 4 );
      assertTrue((  "and(a, d, b, c)" == libsbml.formulaToString(node) ));
      i = node.insertChild(5,newc);
      assertTrue( i == -1 );
      assertTrue( node.getNumChildren() == 4 );
      assertTrue((  "and(a, d, b, c)" == libsbml.formulaToString(node) ));
      i = node.insertChild(2,newc1);
      assertTrue( i == 0 );
      assertTrue( node.getNumChildren() == 5 );
      assertTrue((  "and(a, d, e, b, c)" == libsbml.formulaToString(node) ));
      node = null;
    }

    public void test_ASTNode_isLog10()
    {
      ASTNode n = new  ASTNode();
      ASTNode c;
      n.setType(libsbml.AST_FUNCTION);
      assertTrue( n.isLog10() == false );
      n.setType(libsbml.AST_FUNCTION_LOG);
      assertTrue( n.isLog10() == false );
      c = new  ASTNode();
      n.addChild(c);
      c.setValue(10);
      assertTrue( n.isLog10() == false );
      n.addChild(new  ASTNode());
      assertTrue( n.isLog10() == true );
      c.setValue(2);
      assertTrue( n.isLog10() == false );
      n = null;
    }

    public void test_ASTNode_isSqrt()
    {
      ASTNode n = new  ASTNode();
      ASTNode c;
      n.setType(libsbml.AST_FUNCTION);
      assertTrue( n.isSqrt() == false );
      n.setType(libsbml.AST_FUNCTION_ROOT);
      assertTrue( n.isSqrt() == false );
      c = new  ASTNode();
      n.addChild(c);
      c.setValue(2);
      assertTrue( n.isSqrt() == false );
      n.addChild(new  ASTNode());
      assertTrue( n.isSqrt() == true );
      c.setValue(3);
      assertTrue( n.isSqrt() == false );
      n = null;
    }

    public void test_ASTNode_isUMinus()
    {
      ASTNode n = new  ASTNode();
      n.setType(libsbml.AST_MINUS);
      assertTrue( n.isUMinus() == false );
      n.addChild(new  ASTNode(libsbml.AST_NAME));
      assertTrue( n.isUMinus() == true );
      n = null;
    }

    public void test_ASTNode_no_children()
    {
      ASTNode node = new  ASTNode();
      assertTrue( node.getNumChildren() == 0 );
      assertTrue( node.getLeftChild() == null );
      assertTrue( node.getRightChild() == null );
      assertTrue( node.getChild(0) == null );
      node = null;
    }

    public void test_ASTNode_one_child()
    {
      ASTNode node = new  ASTNode();
      ASTNode child = new  ASTNode();
      node.addChild(child);
      assertTrue( node.getNumChildren() == 1 );
      assertTrue( node.getLeftChild() == child );
      assertTrue( node.getRightChild() == null );
      assertTrue( node.getChild(0) == child );
      assertTrue( node.getChild(1) == null );
      node = null;
    }

    public void test_ASTNode_removeChild()
    {
      ASTNode node = new  ASTNode();
      ASTNode c1 = new  ASTNode();
      ASTNode c2 = new  ASTNode();
      long i = 0;
      node.setType(libsbml.AST_PLUS);
      c1.setName( "foo");
      c2.setName( "foo2");
      node.addChild(c1);
      node.addChild(c2);
      assertTrue( node.getNumChildren() == 2 );
      i = node.removeChild(0);
      assertTrue( i == 0 );
      assertTrue( node.getNumChildren() == 1 );
      i = node.removeChild(1);
      assertTrue( i == -1 );
      assertTrue( node.getNumChildren() == 1 );
      i = node.removeChild(0);
      assertTrue( i == 0 );
      assertTrue( node.getNumChildren() == 0 );
      node = null;
    }

    public void test_ASTNode_replaceChild()
    {
      ASTNode node = new  ASTNode();
      ASTNode c1 = new  ASTNode();
      ASTNode c2 = new  ASTNode();
      ASTNode c3 = new  ASTNode();
      ASTNode newc = new  ASTNode();
      long i = 0;
      node.setType(libsbml.AST_LOGICAL_AND);
      c1.setName( "a");
      c2.setName( "b");
      c3.setName( "c");
      node.addChild(c1);
      node.addChild(c2);
      node.addChild(c3);
      assertTrue( node.getNumChildren() == 3 );
      assertTrue((  "and(a, b, c)" == libsbml.formulaToString(node) ));
      newc.setName( "d");
      i = node.replaceChild(0,newc);
      assertTrue( i == 0 );
      assertTrue( node.getNumChildren() == 3 );
      assertTrue((  "and(d, b, c)" == libsbml.formulaToString(node) ));
      i = node.replaceChild(3,newc);
      assertTrue( i == -1 );
      assertTrue( node.getNumChildren() == 3 );
      assertTrue((  "and(d, b, c)" == libsbml.formulaToString(node) ));
      i = node.replaceChild(1,c1);
      assertTrue( i == 0 );
      assertTrue( node.getNumChildren() == 3 );
      assertTrue((  "and(d, a, c)" == libsbml.formulaToString(node) ));
      node = null;
    }

    public void test_ASTNode_setCharacter()
    {
      ASTNode node = new  ASTNode();
      node.setName( "foo");
      assertTrue( node.getType() == libsbml.AST_NAME );
      assertTrue( node.getCharacter() == '\0' );
      assertTrue((  "foo" == node.getName() ));
      assertTrue( node.getInteger() == 0 );
      assertTrue( node.getReal() == 0 );
      assertTrue( node.getExponent() == 0 );
      assertTrue( node.getDenominator() == 1 );
      node.setCharacter( '+');
      assertTrue( node.getType() == libsbml.AST_PLUS );
      assertTrue( node.getCharacter() ==  '+'       );
      assertTrue( node.getName() == null );
      assertTrue( node.getInteger() == 0 );
      assertTrue( node.getReal() == 0 );
      assertTrue( node.getExponent() == 0 );
      assertTrue( node.getDenominator() == 1 );
      node.setCharacter( '-');
      assertTrue( node.getType() == libsbml.AST_MINUS );
      assertTrue( node.getCharacter() ==  '-'        );
      assertTrue( node.getName() == null );
      assertTrue( node.getInteger() == 0 );
      assertTrue( node.getReal() == 0 );
      assertTrue( node.getExponent() == 0 );
      assertTrue( node.getDenominator() == 1 );
      node.setCharacter( '*');
      assertTrue( node.getType() == libsbml.AST_TIMES );
      assertTrue( node.getCharacter() ==  '*'        );
      assertTrue( node.getName() == null );
      assertTrue( node.getInteger() == 0 );
      assertTrue( node.getReal() == 0 );
      assertTrue( node.getExponent() == 0 );
      assertTrue( node.getDenominator() == 1 );
      node.setCharacter( '/');
      assertTrue( node.getType() == libsbml.AST_DIVIDE );
      assertTrue( node.getCharacter() ==  '/'         );
      assertTrue( node.getName() == null );
      assertTrue( node.getInteger() == 0 );
      assertTrue( node.getReal() == 0 );
      assertTrue( node.getExponent() == 0 );
      assertTrue( node.getDenominator() == 1 );
      node.setCharacter( '^');
      assertTrue( node.getType() == libsbml.AST_POWER );
      assertTrue( node.getCharacter() ==  '^'        );
      assertTrue( node.getName() == null );
      assertTrue( node.getInteger() == 0 );
      assertTrue( node.getReal() == 0 );
      assertTrue( node.getExponent() == 0 );
      assertTrue( node.getDenominator() == 1 );
      node.setCharacter( '$');
      assertTrue( node.getType() == libsbml.AST_UNKNOWN );
      assertTrue( node.getCharacter() ==  '$'          );
      assertTrue( node.getName() == null );
      assertTrue( node.getInteger() == 0 );
      assertTrue( node.getReal() == 0 );
      assertTrue( node.getExponent() == 0 );
      assertTrue( node.getDenominator() == 1 );
      node = null;
    }

    public void test_ASTNode_setInteger()
    {
      ASTNode node = new  ASTNode();
      node.setName( "foo");
      assertTrue( node.getType() == libsbml.AST_NAME );
      assertTrue((  "foo" == node.getName() ));
      assertTrue( node.getCharacter() == '\0' );
      assertTrue( node.getInteger() == 0 );
      assertTrue( node.getReal() == 0 );
      assertTrue( node.getExponent() == 0 );
      assertTrue( node.getDenominator() == 1 );
      node.setValue(3.2);
      assertTrue( node.getType() == libsbml.AST_REAL );
      assertTrue( node.getInteger() == 0 );
      assertTrue( node.getName() == null );
      assertTrue( node.getCharacter() == '\0' );
      assertTrue( node.getReal() == 3.2 );
      assertTrue( node.getExponent() == 0 );
      assertTrue( node.getDenominator() == 1 );
      node.setValue(321);
      assertTrue( node.getType() == libsbml.AST_INTEGER );
      assertTrue( node.getInteger() == 321 );
      assertTrue( node.getName() == null );
      assertTrue( node.getCharacter() == '\0' );
      assertTrue( node.getReal() == 0 );
      assertTrue( node.getExponent() == 0 );
      assertTrue( node.getDenominator() == 1 );
      node = null;
    }

    public void test_ASTNode_setName()
    {
      string name =  "foo";;
      ASTNode node = new  ASTNode();
      assertTrue( node.getType() == libsbml.AST_UNKNOWN );
      node.setName(name);
      assertTrue( node.getType() == libsbml.AST_NAME );
      assertTrue(( name == node.getName() ));
      assertTrue( node.getCharacter() == '\0' );
      assertTrue( node.getInteger() == 0 );
      assertTrue( node.getReal() == 0 );
      assertTrue( node.getExponent() == 0 );
      assertTrue( node.getDenominator() == 1 );
      if (node.getName() == name);
      {
      }
      node.setName(null);
      assertTrue( node.getType() == libsbml.AST_NAME );
      if (node.getName() != null);
      {
      }
      node.setType(libsbml.AST_FUNCTION_COS);
      assertTrue( node.getType() == libsbml.AST_FUNCTION_COS );
      assertTrue((  "cos" == node.getName() ));
      assertTrue( node.getCharacter() == '\0' );
      assertTrue( node.getInteger() == 0 );
      assertTrue( node.getReal() == 0 );
      assertTrue( node.getExponent() == 0 );
      assertTrue( node.getDenominator() == 1 );
      node.setType(libsbml.AST_PLUS);
      node.setName(name);
      assertTrue( node.getType() == libsbml.AST_NAME );
      assertTrue(( name == node.getName() ));
      assertTrue( node.getCharacter() ==  '+'         );
      assertTrue( node.getInteger() == 0 );
      assertTrue( node.getReal() == 0 );
      assertTrue( node.getExponent() == 0 );
      assertTrue( node.getDenominator() == 1 );
      node = null;
    }

    public void test_ASTNode_setName_override()
    {
      ASTNode node = new  ASTNode(libsbml.AST_FUNCTION_SIN);
      assertTrue((  "sin" == node.getName() ));
      assertTrue( node.getType() == libsbml.AST_FUNCTION_SIN );
      node.setName( "MySinFunc");
      assertTrue((  "MySinFunc" == node.getName() ));
      assertTrue( node.getType() == libsbml.AST_FUNCTION_SIN );
      node.setName(null);
      assertTrue((  "sin" == node.getName() ));
      assertTrue( node.getType() == libsbml.AST_FUNCTION_SIN );
      node = null;
    }

    public void test_ASTNode_setReal()
    {
      ASTNode node = new  ASTNode();
      node.setName( "foo");
      assertTrue( node.getType() == libsbml.AST_NAME );
      node.setValue(32.1);
      assertTrue( node.getType() == libsbml.AST_REAL );
      assertTrue( node.getInteger() == 0 );
      assertTrue( node.getName() == null );
      assertTrue( node.getCharacter() == '\0' );
      assertTrue( node.getReal() == 32.1 );
      assertTrue( node.getExponent() == 0 );
      assertTrue( node.getDenominator() == 1 );
      assertTrue( node.getMantissa() == 32.1 );
      node.setValue(45,90);
      assertTrue( node.getType() == libsbml.AST_RATIONAL );
      assertTrue( node.getInteger() == 45 );
      assertTrue( node.getName() == null );
      assertTrue( node.getCharacter() == '\0' );
      assertTrue( node.getReal() == 0.5 );
      assertTrue( node.getExponent() == 0 );
      assertTrue( node.getDenominator() == 90 );
      assertTrue( node.getMantissa() == 0 );
      node.setValue(32.0,4);
      assertTrue( node.getType() == libsbml.AST_REAL_E );
      assertTrue( node.getInteger() == 0 );
      assertTrue( node.getName() == null );
      assertTrue( node.getCharacter() == '\0' );
      assertTrue( node.getReal() == 320000 );
      assertTrue( node.getExponent() == 4 );
      assertTrue( node.getDenominator() == 1 );
      assertTrue( node.getMantissa() == 32 );
      node = null;
    }

    public void test_ASTNode_setType()
    {
      ASTNode node = new  ASTNode();
      node.setName( "foo");
      assertTrue( node.getType() == libsbml.AST_NAME );
      node.setType(libsbml.AST_FUNCTION);
      assertTrue( node.getType() == libsbml.AST_FUNCTION );
      assertTrue((  "foo" == node.getName() ));
      node.setType(libsbml.AST_NAME);
      assertTrue( node.getType() == libsbml.AST_NAME );
      assertTrue((  "foo" == node.getName() ));
      node.setType(libsbml.AST_INTEGER);
      assertTrue( node.getType() == libsbml.AST_INTEGER );
      node.setType(libsbml.AST_REAL);
      assertTrue( node.getType() == libsbml.AST_REAL );
      node.setType(libsbml.AST_UNKNOWN);
      assertTrue( node.getType() == libsbml.AST_UNKNOWN );
      node.setType(libsbml.AST_PLUS);
      assertTrue( node.getType() == libsbml.AST_PLUS );
      assertTrue( node.getCharacter() ==  '+'       );
      node.setType(libsbml.AST_MINUS);
      assertTrue( node.getType() == libsbml.AST_MINUS );
      assertTrue( node.getCharacter() ==  '-'        );
      node.setType(libsbml.AST_TIMES);
      assertTrue( node.getType() == libsbml.AST_TIMES );
      assertTrue( node.getCharacter() ==  '*'        );
      node.setType(libsbml.AST_DIVIDE);
      assertTrue( node.getType() == libsbml.AST_DIVIDE );
      assertTrue( node.getCharacter() ==  '/'         );
      node.setType(libsbml.AST_POWER);
      assertTrue( node.getType() == libsbml.AST_POWER );
      assertTrue( node.getCharacter() ==  '^'        );
      node = null;
    }

  }
}
